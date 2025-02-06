import { Operation, Parameter, Property, SchemaType } from "@autorest/codemodel";
import _ from "lodash";
import pluralize, { singular } from "pluralize";
import { getSession } from "../autorest-session";
import { getDataTypes } from "../data-types";
import {
  ArmResourceKind,
  TypespecDecorator,
  TypespecObjectProperty,
  TypespecParameter,
  TspArmResource,
  TspArmResourceOperation,
  isFirstLevelResource,
  TypespecTemplateModel,
  TspArmOperationType,
  TspArmResourceActionOperation,
  TspArmResourceOperationBase,
  TypespecVoidType,
  TspArmResourceLifeCycleOperation,
  TspArmResourceListOperation,
  isArmResourceActionOperation,
  TspArmResourceLegacyOperationGroup,
  TspArmResourceOperationGroup,
  TypespecSpreadStatement,
} from "../interfaces";
import { transformDataType } from "../model";
import { getOptions, updateOptions } from "../options";
import { createClientNameDecorator, createCSharpNameDecorator } from "../pretransforms/rename-pretransform";
import { isExtendedLocation, isManagedSerivceIdentity, isPlan, isSku } from "../utils/common-type-mapping";
import { getOperationClientDecorators, getPropertyDecorators } from "../utils/decorators";
import { generateDocsContent } from "../utils/docs";
import { getLogger } from "../utils/logger";
import {
  ArmResource,
  ArmResourceSchema,
  _ArmResourceOperation,
  getResourceOperations,
  isResourceSchema,
} from "../utils/resource-discovery";
import { isArraySchema, isStringSchema } from "../utils/schemas";
import { escapeRegex } from "../utils/strings";
import { getSuppresssionWithCode } from "../utils/suppressions";
import { getFullyQualifiedName, getTemplateResponses, NamesOfResponseTemplate } from "../utils/type-mapping";
import { getTypespecType, isTypespecType, transformObjectProperty } from "./transform-object";
import { transformParameter } from "./transform-operations";

const logger = () => getLogger("transform-arm-resources");

const armResourceCache: Map<ArmResourceSchema, TspArmResource> = new Map<ArmResourceSchema, TspArmResource>();
export function transformTspArmResource(schema: ArmResourceSchema): TspArmResource {
  if (armResourceCache.has(schema)) return armResourceCache.get(schema)!;

  const { isFullCompatible } = getOptions();
  const fixMe: string[] = [];

  if (!getSession().configuration["namespace"]) {
    const segments = schema.resourceMetadata[0].GetOperation!.Path.split("/");
    for (let i = segments.length - 1; i >= 0; i--) {
      if (segments[i] === "providers") {
        getSession().configuration["namespace"] = segments[i + 1];
        updateOptions();
        break;
      }
    }
  }

  // TODO: deal with a resource with multiple parents
  if (schema.resourceMetadata[0].Parents.length > 1) {
    fixMe.push(
      `// FIXME: ${schema.resourceMetadata[0].SwaggerModelName} has more than one parent, currently converter will only use the first one`,
    );
  }

  const propertiesModel = schema.properties?.find((p) => p.serializedName === "properties");
  const propertiesModelSchema = propertiesModel?.schema;
  let propertiesModelName = propertiesModelSchema?.language.default.name;
  let propertiesPropertyRequired = false;
  let propertiesPropertyDescription = "";

  if (propertiesModelSchema?.type === SchemaType.Dictionary) {
    propertiesModelName = "Record<unknown>";
  } else if (propertiesModelSchema?.type === SchemaType.Object) {
    propertiesPropertyRequired = propertiesModel?.required ?? false;
    propertiesPropertyDescription = propertiesModel?.language.default.description ?? "";
  }

  // TODO: deal with resources that has no properties property
  if (!propertiesModelName) {
    fixMe.push(`// FIXME: ${schema.resourceMetadata[0].SwaggerModelName} has no properties property`);
    propertiesModelName = "{}";
  }

  const armResourceOperationGroups = getTspOperationGroups(schema);

  const decorators = buildResourceDecorators(schema);
  if (schema.resourceMetadata[0].IsExtensionResource) {
    decorators.push({ name: "extensionResource" });
  }

  const clientDecorators = buildResourceClientDecorators(schema);
  const keyProperty = buildKeyProperty(schema);
  const properties = [keyProperty, ...getOtherProperties(schema)];
  const augmentDecorators = buildKeyAugmentDecorators(schema, keyProperty) ?? [];

  if (propertiesModel) {
    augmentDecorators.push(...buildPropertiesAugmentDecorators(schema, propertiesModel));
  }

  const propertiesPropertyClientDecorator = [];
  if (isFullCompatible && propertiesModel?.extensions?.["x-ms-client-flatten"]) {
    propertiesPropertyClientDecorator.push({
      name: "flattenProperty",
      module: "@azure-tools/typespec-client-generator-core",
      namespace: "Azure.ClientGenerator.Core",
      suppressionCode: "deprecated",
      suppressionMessage: "@flattenProperty decorator is not recommended to use.",
    });
  }

  const tspResource: TspArmResource = {
    kind: "ArmResource",
    name: schema.resourceMetadata[0].SwaggerModelName,
    fixMe,
    resourceKind: getResourceKind(schema),
    properties,
    resourceParent: getParentResource(schema),
    propertiesModelName,
    propertiesPropertyRequired,
    propertiesPropertyDescription,
    propertiesPropertyClientDecorator,
    doc: schema.language.default.description,
    decorators,
    clientDecorators,
    augmentDecorators,
    resourceOperationGroups: armResourceOperationGroups,
    locationParent: getLocationParent(schema),
  };
  armResourceCache.set(schema, tspResource);
  return tspResource;
}

function getTspOperationGroups(armSchema: ArmResourceSchema): TspArmResourceOperationGroup[] {
  const operationGroups: TspArmResourceOperationGroup[] = [];
  for (const resourceMetadata of armSchema.resourceMetadata) {
    const operations = getResourceOperations(resourceMetadata);
    const interfaceName = getTSPOperationGroupName(resourceMetadata);
    const tspOperations: TspArmResourceOperation[] = [];

    // TODO: handle operations under resource group / management group / tenant

    // read operation
    tspOperations.push(...convertResourceReadOperation(resourceMetadata, operations));

    // exist operation
    tspOperations.push(...convertResourceExistsOperation(resourceMetadata, operations));

    // create operation
    tspOperations.push(...convertResourceCreateOrReplaceOperation(resourceMetadata, operations));

    // patch update operation could either be patch for resource/tag or custom patch
    tspOperations.push(...convertResourceUpdateOperation(resourceMetadata, operations));

    // delete operation
    tspOperations.push(...convertResourceDeleteOperation(resourceMetadata, operations));

    // list operation
    tspOperations.push(...convertResourceListOperations(resourceMetadata, operations));

    // action operation
    tspOperations.push(...convertResourceActionOperations(resourceMetadata, operations));

    if (armSchema.resourceMetadata.length === 1) {
      return [
        {
          isLegacy: false,
          interfaceName,
          resourceOperations: tspOperations,
        },
      ];
    }

    operationGroups.push({
      isLegacy: true,
      interfaceName,
      resourceOperations: tspOperations,
      legacyOperationGroup: convertLegacyOperationGroup(resourceMetadata),
    });
  }

  return operationGroups;
}

function convertLegacyOperationGroup(armResource: ArmResource): TspArmResourceLegacyOperationGroup {
  const pathParameters = getPathParameters(armResource);
  const lastParameter = pathParameters.pop();

  const parentParameters: string[] = ["...ApiVersionParameter"];
  for (const parameter of pathParameters) {
    if (parameter.keyName === "subscriptionId") {
      parentParameters.push("...SubscriptionIdParameter");
    } else if (parameter.keyName === "resourceGroupName") {
      parentParameters.push("...ResourceGroupParameter");
    } else if (parameter.keyName === "location") {
      parentParameters.push("...LocationParameter");
    } else if (parameter.segmentName === "providers") {
      parentParameters.push("...Azure.ResourceManager.Legacy.Provider");
    } else {
      const resourceNameParameter = buildResourceNameParameterForSegment(
        parameter.segmentName,
        parameter.keyName,
        parameter.pattern,
      );
      if (resourceNameParameter) {
        parentParameters.push(resourceNameParameter);
      } else {
        parentParameters.push(
          `/** ${parameter.segmentName} */\n@path @segment("${parameter.segmentName}") ${parameter.keyName}: string`,
        );
      }
    }
  }

  const resourceTypeParameter = `KeysOf<ResourceNameParameter<
    Resource = ${armResource.SwaggerModelName},
    KeyName = "${lastParameter!.keyName}",
    SegmentName = "${lastParameter!.segmentName}",
    NamePattern = "${lastParameter!.pattern}"
  >>`;
  const interfaceName = `${singular(getTSPOperationGroupName(armResource))}Ops`;
  return {
    interfaceName,
    parentParameters,
    resourceTypeParameter,
  };
}

function buildResourceNameParameterForSegment(
  segmentName: string,
  keyName: string,
  pattern: string,
): string | undefined {
  for (const objectSchema of getSession().model.schemas.objects ?? []) {
    if (!isResourceSchema(objectSchema)) {
      continue;
    }

    const resource = objectSchema.resourceMetadata.find(
      (r) => r.ResourceKeySegment === segmentName && r.ResourceKey === keyName,
    );
    if (resource === undefined) continue;

    return `...KeysOf<ResourceNameParameter<
    Resource = ${resource.SwaggerModelName},
    KeyName = "${keyName}",
    SegmentName = "${segmentName}",
    NamePattern = "${pattern}"
  >>`;
  }
  return undefined;
}

function convertResourceReadOperation(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceOperation[] {
  // every resource should have a get operation
  const operation = resourceMetadata.GetOperation!;
  const swaggerOperation = operations[operation.OperationID];
  return [
    buildNewArmOperation(
      resourceMetadata,
      operation,
      swaggerOperation,
      "ArmResourceRead",
    ) as TspArmResourceLifeCycleOperation,
  ];
}

function convertResourceExistsOperation(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceOperation[] {
  const operation = resourceMetadata.ExistOperation;
  if (operation) {
    const swaggerOperation = operations[operation.OperationID];
    const armOperation = buildNewArmOperation(
      resourceMetadata,
      operation,
      swaggerOperation,
      "ArmResourceCheckExistence",
    );
    if (!swaggerOperation.operationId) armOperation.name = "exists";
    return [armOperation as TspArmResourceLifeCycleOperation];
  }
  return [];
}

function convertResourceCreateOrReplaceOperation(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceOperation[] {
  const { isFullCompatible } = getOptions();
  if (resourceMetadata.CreateOperation) {
    const operation = resourceMetadata.CreateOperation;
    const swaggerOperation = operations[operation.OperationID];
    const isLongRunning = swaggerOperation.extensions?.["x-ms-long-running-operation"] ?? false;
    const armOperation = buildNewArmOperation(
      resourceMetadata,
      operation,
      swaggerOperation,
      isLongRunning ? "ArmResourceCreateOrReplaceAsync" : "ArmResourceCreateOrReplaceSync",
    );

    const bodyParam = swaggerOperation.requests?.[0].parameters?.find((p) => p.protocol.http?.in === "body");
    if (!bodyParam) {
      armOperation.fixMe = [
        "// FIXME: (ArmResourceCreateOrReplace): ArmResourceCreateOrReplaceAsync/ArmResourceCreateOrReplaceSync should have a body parameter.",
      ];
    }

    const finalStateVia =
      swaggerOperation.extensions?.["x-ms-long-running-operation-options"]?.["final-state-via"] ?? "location";
    armOperation.lroHeaders = isLongRunning && finalStateVia === "location" ? "Location" : undefined;

    buildBodyDecorator(bodyParam, armOperation, resourceMetadata, "resource", "Resource create parameters.");

    const asyncNames: NamesOfResponseTemplate = {
      _200Name: "ArmResourceUpdatedResponse",
      _200NameNoBody: "OkResponse",
      _201Name: "ArmResourceCreatedResponse",
      _201NameNoBody: "CreatedResponse",
      _202Name: "ArmAcceptedLroResponse",
      _202NameNoBody: "ArmAcceptedLroResponse",
      _204Name: "ArmNoContentResponse",
    };
    const syncNames: NamesOfResponseTemplate = {
      _200Name: "ArmResourceUpdatedResponse",
      _200NameNoBody: "OkResponse",
      _201Name: "ArmResourceCreatedSyncResponse",
      _201NameNoBody: "CreatedResponse",
      _202Name: "AcceptedResponse",
      _202NameNoBody: "AcceptedResponse",
      _204Name: "ArmNoContentResponse",
    };
    let responses: TypespecTemplateModel[] = isLongRunning
      ? getTemplateResponses(swaggerOperation, asyncNames)
      : getTemplateResponses(swaggerOperation, syncNames);
    if (
      isLongRunning &&
      responses.length === 2 &&
      responses.find(
        (r) =>
          r.name === asyncNames._200Name &&
          r.arguments?.length === 1 &&
          r.arguments[0].name === resourceMetadata.SwaggerModelName,
      ) &&
      responses.find(
        (r) =>
          r.name === asyncNames._201Name &&
          r.arguments?.length === 1 &&
          r.arguments[0].name === resourceMetadata.SwaggerModelName,
      )
    )
      responses = [];
    if (
      !isLongRunning &&
      responses.length === 2 &&
      responses.find(
        (r) =>
          r.name === syncNames._200Name &&
          r.arguments?.length === 1 &&
          r.arguments[0].name === resourceMetadata.SwaggerModelName,
      ) &&
      responses.find(
        (r) =>
          r.name === syncNames._200Name &&
          r.arguments?.length === 1 &&
          r.arguments[0].name === resourceMetadata.SwaggerModelName,
      )
    )
      responses = [];
    if (responses.length > 0) armOperation.response = responses;
    if (armOperation.lroHeaders && responses) {
      let _201Response = responses.find((r) => r.name === asyncNames._201Name);
      if (_201Response) {
        _201Response.arguments!.push({
          kind: "&",
          name: "ArmLroLocationHeader & Azure.Core.Foundations.RetryAfterHeader",
        }); //TO-DO: do it in a better way
        armOperation.lroHeaders = undefined;
      }

      _201Response = responses.find((r) => r.name === syncNames._201NameNoBody);
      if (_201Response) {
        _201Response.additionalTemplateModel = "ArmLroLocationHeader & Azure.Core.Foundations.RetryAfterHeader";
      }
    }

    if (isFullCompatible) {
      if (armOperation.response) {
        armOperation.suppressions = armOperation.suppressions ?? [];
        armOperation.suppressions.push(
          getSuppresssionWithCode("@azure-tools/typespec-azure-resource-manager/arm-put-operation-response-codes"),
        );

        if (
          (armOperation.response as TypespecTemplateModel[]).find(
            (r) => r.name === asyncNames._202Name && (!r.arguments || r.arguments.length === 0),
          )
        ) {
          armOperation.suppressions.push(
            getSuppresssionWithCode("@azure-tools/typespec-azure-resource-manager/no-response-body"),
          );
        }
      }
    }

    return [armOperation as TspArmResourceLifeCycleOperation];
  }
  return [];
}

function convertResourceUpdateOperation(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceOperation[] {
  if (resourceMetadata.UpdateOperation) {
    const operation = resourceMetadata.UpdateOperation;
    if (!resourceMetadata.CreateOperation || resourceMetadata.CreateOperation.OperationID !== operation.OperationID) {
      const swaggerOperation = operations[operation.OperationID];
      const isLongRunning = swaggerOperation.extensions?.["x-ms-long-running-operation"] ?? false;
      const armOperation = buildNewArmOperation(
        resourceMetadata,
        operation,
        swaggerOperation,
        isLongRunning ? "ArmCustomPatchAsync" : "ArmCustomPatchSync",
      );

      const finalStateVia =
        swaggerOperation.extensions?.["x-ms-long-running-operation-options"]?.["final-state-via"] ?? "location";
      armOperation.lroHeaders =
        isLongRunning && finalStateVia === "azure-async-operation" ? "Azure-AsyncOperation" : undefined;

      const bodyParam = swaggerOperation.requests?.[0].parameters?.find((p) => p.protocol.http?.in === "body");
      if (!bodyParam) {
        armOperation.fixMe = [
          "// FIXME: (ArmResourcePatch): ArmResourcePatchSync/ArmResourcePatchAsync should have a body parameter with either properties property or tag property",
        ];
        armOperation.patchModel = "{}";
      } else {
        armOperation.patchModel = bodyParam.schema.language.default.name;
      }

      buildBodyDecorator(
        bodyParam,
        armOperation,
        resourceMetadata,
        "properties",
        "The resource properties to be updated.",
      );

      const asyncNames: NamesOfResponseTemplate = {
        _200Name: "ArmResponse",
        _200NameNoBody: "OkResponse",
        _201Name: "ArmResourceCreatedResponse",
        _201NameNoBody: "CreatedResponse",
        _202Name: "ArmAcceptedLroResponse",
        _202NameNoBody: "ArmAcceptedLroResponse",
        _204Name: "ArmNoContentResponse",
      };
      const syncNames: NamesOfResponseTemplate = {
        _200Name: "ArmResponse",
        _200NameNoBody: "OkResponse",
        _201Name: "ArmResourceCreatedSyncResponse",
        _201NameNoBody: "CreatedResponse",
        _202Name: "AcceptedResponse",
        _202NameNoBody: "AcceptedResponse",
        _204Name: "ArmNoContentResponse",
      };
      let responses = isLongRunning
        ? getTemplateResponses(swaggerOperation, asyncNames)
        : getTemplateResponses(swaggerOperation, syncNames);
      if (
        isLongRunning &&
        responses.length === 2 &&
        responses.find(
          (r) =>
            r.name === asyncNames._200Name &&
            r.arguments?.length === 1 &&
            r.arguments[0].name === resourceMetadata.SwaggerModelName,
        ) &&
        responses.find((r) => r.name === asyncNames._202NameNoBody && !r.arguments)
      )
        responses = [];
      if (
        !isLongRunning &&
        responses.length === 1 &&
        responses.find(
          (r) =>
            r.name === syncNames._200Name &&
            r.arguments?.length === 1 &&
            r.arguments[0].name === resourceMetadata.SwaggerModelName,
        )
      )
        responses = [];
      if (responses.length > 0) armOperation.response = responses;
      if (armOperation.lroHeaders && responses) {
        const _202response = responses.find(
          (r) => r.name === asyncNames._202NameNoBody || r.name === asyncNames._202Name,
        );
        if (_202response) {
          _202response.arguments = [
            { kind: "&", name: "ArmAsyncOperationHeader & Azure.Core.Foundations.RetryAfterHeader" },
          ]; //TO-DO: do it in a better way
          armOperation.lroHeaders = undefined;
        }
      }

      armOperation.decorators = [{ name: "parameterVisibility", arguments: [] }];
      return [armOperation as TspArmResourceLifeCycleOperation];
    }
  }
  return [];
}

function convertResourceDeleteOperation(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceOperation[] {
  const { isFullCompatible } = getOptions();

  if (resourceMetadata.DeleteOperation) {
    const operation = resourceMetadata.DeleteOperation;
    const swaggerOperation = operations[operation.OperationID];
    const isLongRunning = swaggerOperation.extensions?.["x-ms-long-running-operation"] ?? false;
    const armOperation = buildNewArmOperation(
      resourceMetadata,
      operation,
      swaggerOperation,
      isLongRunning ? "ArmResourceDeleteWithoutOkAsync" : "ArmResourceDeleteSync",
    );

    const finalStateVia =
      swaggerOperation.extensions?.["x-ms-long-running-operation-options"]?.["final-state-via"] ?? "location";
    armOperation.lroHeaders =
      isLongRunning && finalStateVia === "azure-async-operation" ? "Azure-AsyncOperation" : undefined;

    if (armOperation.lroHeaders && isFullCompatible) {
      armOperation.suppressions = armOperation.suppressions ?? [];
      armOperation.suppressions.push(
        getSuppresssionWithCode("@azure-tools/typespec-azure-resource-manager/lro-location-header"),
      );
    }

    const asyncNames: NamesOfResponseTemplate = {
      _200Name: "ArmResponse",
      _200NameNoBody: "ArmDeletedResponse",
      _201Name: "ArmResourceCreatedResponse",
      _201NameNoBody: "CreatedResponse",
      _202Name: "ArmDeleteAcceptedLroResponse",
      _202NameNoBody: "ArmDeleteAcceptedLroResponse",
      _204Name: "ArmDeletedNoContentResponse",
    };
    const syncNames: NamesOfResponseTemplate = {
      _200Name: "ArmResponse",
      _200NameNoBody: "ArmDeletedResponse",
      _201Name: "ArmResourceCreatedSyncResponse",
      _201NameNoBody: "CreatedResponse",
      _202Name: "AcceptedResponse",
      _202NameNoBody: "AcceptedResponse",
      _204Name: "ArmDeletedNoContentResponse",
    };
    let responses = isLongRunning
      ? getTemplateResponses(swaggerOperation, asyncNames)
      : getTemplateResponses(swaggerOperation, syncNames);
    if (
      isLongRunning &&
      responses.length === 2 &&
      responses.find((r) => r.name === asyncNames._202NameNoBody && !r.arguments) &&
      responses.find((r) => r.name === asyncNames._204Name && !r.arguments)
    )
      responses = [];
    if (
      !isLongRunning &&
      responses.length === 2 &&
      responses.find((r) => r.name === syncNames._200NameNoBody && !r.arguments) &&
      responses.find((r) => r.name === asyncNames._204Name && !r.arguments)
    )
      responses = [];
    if (armOperation.lroHeaders && responses) {
      const _202response = responses.find(
        (r) => r.name === asyncNames._202NameNoBody || r.name === asyncNames._202Name,
      );
      if (_202response) {
        _202response.arguments = [
          { kind: "&", name: "ArmAsyncOperationHeader & Azure.Core.Foundations.RetryAfterHeader" },
        ]; //TO-DO: do it in a better way
        armOperation.lroHeaders = undefined;
      }
    }
    if (responses.length > 0) armOperation.response = responses;

    if (armOperation.response && isFullCompatible) {
      armOperation.suppressions = armOperation.suppressions ?? [];
      armOperation.suppressions.push(
        getSuppresssionWithCode("@azure-tools/typespec-azure-resource-manager/arm-delete-operation-response-codes"),
      );
    }

    return [armOperation as TspArmResourceLifeCycleOperation];
  }
  return [];
}

function convertResourceListOperations(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceOperation[] {
  const converted: TspArmResourceOperation[] = [];

  // list by parent operation
  if (resourceMetadata.ListOperations.length) {
    // TODO: TParentName, TParentFriendlyName
    const operation = resourceMetadata.ListOperations[0];
    const swaggerOperation = operations[operation.OperationID];
    const armOperation = buildNewArmOperation(resourceMetadata, operation, swaggerOperation, "ArmResourceListByParent");

    const syncNames: NamesOfResponseTemplate = {
      _200Name: "ArmResponse",
      _200NameNoBody: "OkResponse",
      _201Name: "ArmResourceCreatedSyncResponse",
      _201NameNoBody: "CreatedResponse",
      _202Name: "AcceptedResponse",
      _202NameNoBody: "AcceptedResponse",
      _204Name: "NoContentResponse",
    };
    let responses = getTemplateResponses(swaggerOperation, syncNames);
    if (
      responses.length === 1 &&
      responses[0].name === syncNames._200Name &&
      responses[0].arguments?.[0].name === "ResourceListResult"
    )
      responses = [];
    if (responses.length > 0) armOperation.response = responses;

    converted.push(armOperation as TspArmResourceListOperation);
  }

  // list operation under subscription
  if (resourceMetadata.OperationsFromSubscriptionExtension.length) {
    for (const operation of resourceMetadata.OperationsFromSubscriptionExtension) {
      if (operation.PagingMetadata) {
        const swaggerOperation = operations[operation.OperationID];
        const armOperation = buildNewArmOperation(
          resourceMetadata,
          operation,
          swaggerOperation,
          "ArmResourceListAtScope",
        );

        const syncNames: NamesOfResponseTemplate = {
          _200Name: "ArmResponse",
          _200NameNoBody: "OkResponse",
          _201Name: "ArmResourceCreatedSyncResponse",
          _201NameNoBody: "CreatedResponse",
          _202Name: "AcceptedResponse",
          _202NameNoBody: "AcceptedResponse",
          _204Name: "NoContentResponse",
        };
        let responses = getTemplateResponses(swaggerOperation, syncNames);
        if (
          responses.length === 1 &&
          responses[0].name === syncNames._200Name &&
          responses[0].arguments?.[0].name === "ResourceListResult"
        )
          responses = [];
        if (responses.length > 0) armOperation.response = responses;

        // either list in location or list in subscription
        if (operation.Path.includes("/locations/")) {
          armOperation.baseParameters = [getFullyQualifiedName("LocationBaseParameters")];
        } else {
          armOperation.kind = "ArmListBySubscription";
        }
        converted.push(armOperation as TspArmResourceListOperation);
      }
    }
  }

  return converted;
}

function convertResourceActionOperations(
  resourceMetadata: ArmResource,
  operations: Record<string, Operation>,
): TspArmResourceActionOperation[] {
  const converted: TspArmResourceActionOperation[] = [];

  if (resourceMetadata.OtherOperations.length) {
    for (const operation of resourceMetadata.OtherOperations) {
      const swaggerOperation = operations[operation.OperationID];
      const isLongRunning = swaggerOperation.extensions?.["x-ms-long-running-operation"] ?? false;
      const armOperation = buildNewArmOperation(
        resourceMetadata,
        operation,
        swaggerOperation,
        isLongRunning ? "ArmResourceActionAsync" : "ArmResourceActionSync",
      );

      const finalStateVia =
        swaggerOperation.extensions?.["x-ms-long-running-operation-options"]?.["final-state-via"] ?? "location";
      armOperation.lroHeaders =
        isLongRunning && finalStateVia === "azure-async-operation" ? "Azure-AsyncOperation" : undefined;

      buildRequestForAction(
        armOperation,
        swaggerOperation,
        resourceMetadata,
        true,
        "body",
        "The content of the action request",
      );

      armOperation.decorators = armOperation.decorators ?? [];
      if (operation.Method !== "POST") {
        armOperation.decorators.push({ name: operation.Method.toLocaleLowerCase() });
      }
      const segments = operation.Path.split("/");
      if (segments[segments.length - 1] !== armOperation.name) {
        armOperation.decorators.push({ name: "action", arguments: [segments[segments.length - 1]] });
      }

      const asyncNames: NamesOfResponseTemplate = {
        _200Name: "ArmResponse",
        _200NameNoBody: "OkResponse",
        _201Name: "ArmResourceCreatedResponse",
        _201NameNoBody: "CreatedResponse",
        _202Name: "ArmAcceptedLroResponse",
        _202NameNoBody: "ArmAcceptedLroResponse",
        _204Name: "NoContentResponse",
      };
      const syncNames: NamesOfResponseTemplate = {
        _200Name: "ArmResponse",
        _200NameNoBody: "OkResponse",
        _201Name: "ArmResourceCreatedSyncResponse",
        _201NameNoBody: "CreatedResponse",
        _202Name: "AcceptedResponse",
        _202NameNoBody: "AcceptedResponse",
        _204Name: "NoContentResponse",
      };
      let responses: TypespecTemplateModel[] | TypespecVoidType = isLongRunning
        ? getTemplateResponses(swaggerOperation, asyncNames)
        : getTemplateResponses(swaggerOperation, syncNames);

      if (isLongRunning) {
        const _202NoBodyResponseIndex = responses.findIndex(
          (r) => r.name === asyncNames._202NameNoBody && !r.arguments,
        );
        if (_202NoBodyResponseIndex >= 0) {
          responses.splice(_202NoBodyResponseIndex, 1);
        } else {
          armOperation.kind = "ArmResourceActionAsyncBase";
          armOperation.baseParameters = armOperation.baseParameters ?? [
            `${getFullyQualifiedName("DefaultBaseParameters")}<${armOperation.resource}>`,
          ];
          const _202Response = responses.find((r) => r.name === asyncNames._202Name);
          if (_202Response && armOperation.lroHeaders === "Azure-AsyncOperation") {
            _202Response.arguments!.push({
              kind: "&",
              name: "ArmAsyncOperationHeader & Azure.Core.Foundations.RetryAfterHeader",
            });
          }
        }
      }
      if (responses.length === 0) responses = { kind: "void", name: "_" };
      armOperation.response = responses;

      converted.push(armOperation as TspArmResourceActionOperation);
    }
  }

  return converted;
}

function buildRequestForAction(
  armOperation: TspArmResourceOperationBase,
  operation: Operation,
  resourceMetadata: ArmResource,
  templateRequired: boolean,
  templateName: string,
  templateDoc: string,
): void {
  if (!isArmResourceActionOperation(armOperation)) {
    throw new Error(`Operation ${operation.operationId} is not an action operation.`);
  }

  const bodyParam = operation.requests?.[0].parameters?.find((p) => p.protocol.http?.in === "body");
  if (bodyParam === undefined) {
    armOperation.request = { kind: "void", name: "_" };
    return;
  }

  const bodyType = getTypespecType(bodyParam.schema, getSession().model);
  if (bodyParam.required !== templateRequired || isTypespecType(bodyType)) {
    armOperation.request = {
      kind: "parameter",
      type: bodyType,
      name: bodyParam.language.default.name,
      isOptional: !bodyParam.required,
      location: "body",
      serializedName: "_",
      decorators: [{ name: "bodyRoot" }],
      doc: bodyParam.language.default.description,
    };
    return;
  }

  armOperation.request = { kind: "object", name: bodyType };
  buildBodyDecorator(bodyParam, armOperation, resourceMetadata, templateName, templateDoc);
}

function buildBodyDecorator(
  bodyParam: Parameter | undefined,
  armOperation: TspArmResourceOperationBase,
  resourceMetadata: ArmResource,
  templateName: string,
  templateDoc: string,
): void {
  const tspOperationGroupName = getTSPOperationGroupName(resourceMetadata);
  const [augmentedDecorators, clientDecorators] = getBodyDecorators(
    bodyParam,
    tspOperationGroupName,
    armOperation.name,
    templateName,
    templateDoc,
  );
  armOperation.augmentedDecorators = armOperation.augmentedDecorators
    ? armOperation.augmentedDecorators.concat(augmentedDecorators)
    : augmentedDecorators;
  armOperation.clientDecorators = armOperation.clientDecorators
    ? armOperation.clientDecorators.concat(clientDecorators)
    : clientDecorators;
}

function getOtherProperties(schema: ArmResourceSchema): (TypespecObjectProperty | TypespecSpreadStatement)[] {
  const knownProperties = ["properties", "name", "id", "type", "systemData"];
  const resourceKind = getResourceKind(schema);
  if (resourceKind === "TrackedResource") {
    knownProperties.push(...["location", "tags"]);
  }
  const otherProperties: (TypespecObjectProperty | TypespecSpreadStatement)[] = [];
  for (const property of schema.properties ?? []) {
    if (!knownProperties.includes(property.serializedName)) {
      const envolopeProperty = getEnvolopeProperty(property);
      otherProperties.push(
        envolopeProperty ?? {
          ...transformObjectProperty(property, getSession().model),
          suppressions: getOptions().isFullCompatible
            ? [
                getSuppresssionWithCode(
                  "@azure-tools/typespec-azure-resource-manager/arm-resource-invalid-envelope-property",
                ),
              ]
            : undefined,
        },
      );
    }
  }
  return otherProperties;
}

function getEnvolopeProperty(property: Property): TypespecSpreadStatement | undefined {
  if (property.serializedName === "sku" && !property.required && isSku(property.schema)) {
    return {
      kind: "spread",
      model: {
        kind: "template",
        name: "Azure.ResourceManager.ResourceSkuProperty",
      },
    };
  }
  if (
    property.serializedName === "extendedLocation" &&
    !property.required &&
    property.readOnly &&
    isExtendedLocation(property.schema)
  ) {
    return {
      kind: "spread",
      model: {
        kind: "template",
        name: "Azure.ResourceManager.ExtendedLocationProperty",
      },
    };
  }
  if (property.serializedName === "plan" && !property.required && isPlan(property.schema)) {
    return {
      kind: "spread",
      model: {
        kind: "template",
        name: "Azure.ResourceManager.ResourcePlanProperty",
      },
    };
  }
  if (
    property.serializedName === "zones" &&
    !property.required &&
    isArraySchema(property.schema) &&
    isStringSchema(property.schema.elementType)
  ) {
    return {
      kind: "spread",
      model: {
        kind: "template",
        name: "Azure.ResourceManager.AvailabilityZonesProperty",
      },
    };
  }
  if (property.serializedName === "identity" && !property.required && isManagedSerivceIdentity(property.schema)) {
    return {
      kind: "spread",
      model: {
        kind: "template",
        name: "Azure.ResourceManager.ManagedServiceIdentityProperty",
      },
    };
  }
  if (property.serializedName === "eTag" && !property.required && isStringSchema(property.schema)) {
    return {
      kind: "spread",
      model: {
        kind: "template",
        name: "Azure.ResourceManager.EntityTagProperty",
      },
    };
  }
}

const operationGroupNameCache: Map<ArmResource, string> = new Map<ArmResource, string>();
export function getTSPOperationGroupName(resourceMetadata: ArmResource): string {
  if (operationGroupNameCache.has(resourceMetadata)) return operationGroupNameCache.get(resourceMetadata)!;

  // Try pluralizing the resource name first
  let operationGroupName = pluralize(resourceMetadata.SwaggerModelName);
  if (operationGroupName !== resourceMetadata.SwaggerModelName && !isExistingOperationGroupName(operationGroupName)) {
    operationGroupNameCache.set(resourceMetadata, operationGroupName);
  } else {
    // Try operationId then
    operationGroupName = resourceMetadata.GetOperation!.OperationID.split("_")[0];
    if (operationGroupName !== resourceMetadata.SwaggerModelName && !isExistingOperationGroupName(operationGroupName)) {
      operationGroupNameCache.set(resourceMetadata, operationGroupName);
    } else {
      operationGroupName = `${resourceMetadata.SwaggerModelName}OperationGroup`;
      operationGroupNameCache.set(resourceMetadata, operationGroupName);
    }
  }
  return operationGroupName;
}

function isExistingOperationGroupName(operationGroupName: string): boolean {
  const codeModel = getSession().model;
  return (
    codeModel.schemas.objects?.find((o) => o.language.default.name === operationGroupName) !== undefined ||
    Array.from(operationGroupNameCache.values()).find((v) => v === operationGroupName) !== undefined
  );
}

function getBodyDecorators(
  bodyParam: Parameter | undefined,
  tspOperationGroupName: string,
  operationName: string,
  templateName: string,
  templateDoc: string,
): [string[], TypespecDecorator[]] {
  const { isFullCompatible } = getOptions();

  const augmentedDecorators = [];
  const clientDecorators = [];
  if (bodyParam) {
    if (bodyParam.language.default.name !== templateName && isFullCompatible) {
      clientDecorators.push(
        createClientNameDecorator(
          `${tspOperationGroupName}.${operationName}::parameters.${templateName}`,
          `${bodyParam.language.default.name}`,
        ),
      );
    }
    if (bodyParam.language.default.description !== templateDoc) {
      augmentedDecorators.push(
        `@@doc(${tspOperationGroupName}.\`${operationName}\`::parameters.${templateName}, "${bodyParam.language.default.description}");`,
      );
    }
  }
  return [augmentedDecorators, clientDecorators];
}

function buildNewArmOperation(
  resourceMetadata: ArmResource,
  operation: _ArmResourceOperation,
  swaggerOperation: Operation,
  kind: TspArmOperationType,
): TspArmResourceOperationBase {
  const { baseParameters, parameters } = buildOperationParameters(swaggerOperation, resourceMetadata);
  return {
    doc: operation.Description,
    kind,
    name: getOperationName(getTSPOperationGroupName(resourceMetadata), operation.OperationID),
    resource: resourceMetadata.SwaggerModelName,
    baseParameters: baseParameters.length > 0 ? baseParameters : undefined,
    parameters: parameters.length > 0 ? parameters : undefined,
    operationId: operation.OperationID,
    examples: swaggerOperation.extensions?.["x-ms-examples"],
    clientDecorators: getOperationClientDecorators(swaggerOperation),
  };
}

const existingNames: { [interfaceName: string]: Set<string> } = {};
// TO-DO: Figure out a way to create a new name if the name exists
function getOperationName(interfaceName: string, operationId: string): string {
  if (!operationId) return "";

  let operationName = _.lowerFirst(_.last(operationId.split("_")));
  if (interfaceName in existingNames) {
    if (existingNames[interfaceName].has(operationName)) {
      operationName = _.lowerFirst(
        operationId
          .split("_")
          .map((n) => _.upperFirst(n))
          .join(""),
      );
    }
    existingNames[interfaceName].add(operationName);
  } else {
    existingNames[interfaceName] = new Set<string>([operationName]);
  }
  return operationName;
}

function getPathParameters(resource: ArmResource): { segmentName: string; keyName: string; pattern: string }[] {
  const pathParameters = [];
  const pathSegments = resource.GetOperation!.Path.split("/").filter((s) => s !== "");
  for (let i = 0; i + 1 < pathSegments.length; i += 2) {
    const operation = getSession()
      .model.operationGroups.flatMap((og) => og.operations)
      .find((o) => o.operationId === resource.GetOperation!.OperationID);

    const keyName = pathSegments[i + 1].replace("{", "").replace("}", "");
    const parameter = operation?.parameters?.find((p) => p.language.default.serializedName === keyName);
    const pattern =
      parameter && isStringSchema(parameter.schema) && parameter.schema.pattern
        ? escapeRegex(parameter.schema.pattern)
        : "";

    pathParameters.push({ segmentName: pathSegments[i], keyName, pattern });
  }
  return pathParameters;
}

function buildOperationParameters(
  operation: Operation,
  resource: ArmResource,
): { baseParameters: string[]; parameters: TypespecParameter[] } {
  const codeModel = getSession().model;
  const otherParameters: TypespecParameter[] = [];
  const pathParameters = getPathParameters(resource).map((p) => p.keyName);
  pathParameters.push("api-version");
  pathParameters.push("$host");
  if (operation.parameters) {
    for (const parameter of operation.parameters) {
      if (resource.IsSingletonResource && parameter.schema.type === SchemaType.Constant) {
        continue;
      }
      if (!pathParameters.includes(parameter.language.default.serializedName)) {
        otherParameters.push(transformParameter(parameter, codeModel));
      }
    }
  }

  // By default we don't need any base parameters.
  const parameterTemplate: string[] = [];
  if (resource.IsExtensionResource) {
    parameterTemplate.push(getFullyQualifiedName("ExtensionBaseParameters"));
  } else if (resource.IsTenantResource) {
    parameterTemplate.push(getFullyQualifiedName("TenantBaseParameters"));
  } else if (resource.IsSubscriptionResource) {
    parameterTemplate.push(getFullyQualifiedName("SubscriptionBaseParameters"));
  }

  return {
    baseParameters: parameterTemplate,
    parameters: otherParameters,
  };
}

function getKeyParameter(resourceMetadata: ArmResource): Parameter | undefined {
  for (const operationGroup of getSession().model.operationGroups) {
    for (const operation of operationGroup.operations) {
      if (operation.operationId === resourceMetadata.GetOperation!.OperationID) {
        for (const parameter of operation.parameters ?? []) {
          if (parameter.language.default.serializedName === resourceMetadata.ResourceKey) {
            return parameter;
          }
        }
      }
    }
  }
}

function getParentResource(schema: ArmResourceSchema): TspArmResource | undefined {
  const resourceParent = schema.resourceMetadata[0].Parents?.[0];

  if (!resourceParent || isFirstLevelResource(resourceParent)) {
    return undefined;
  }

  for (const objectSchema of getSession().model.schemas.objects ?? []) {
    if (!isResourceSchema(objectSchema)) {
      continue;
    }

    if (objectSchema.resourceMetadata[0].Name === resourceParent) {
      return transformTspArmResource(objectSchema);
    }
  }
}

function getResourceKind(schema: ArmResourceSchema): ArmResourceKind {
  if (schema.resourceMetadata[0].IsExtensionResource) {
    return "ExtensionResource";
  }

  if (schema.resourceMetadata[0].IsTrackedResource) {
    return "TrackedResource";
  }

  return "ProxyResource";
}

function buildKeyAugmentDecorators(
  schema: ArmResourceSchema,
  keyProperty: TypespecSpreadStatement,
): TypespecDecorator[] {
  return (
    keyProperty.decorators
      ?.filter((d) => !["pattern", "key", "segment", "path"].includes(d.name))
      .filter((d) => !(d.name === "visibility" && d.arguments?.[0] === "read"))
      .map((d) => {
        d.target = `${schema.resourceMetadata[0].SwaggerModelName}.name`;
        return d;
      }) ?? []
  ).concat({
    name: "doc",
    target: `${schema.resourceMetadata[0].SwaggerModelName}.name`,
    arguments: [generateDocsContent(keyProperty)],
  });
}

function buildPropertiesAugmentDecorators(schema: ArmResourceSchema, propertiesModel: Property): TypespecDecorator[] {
  return [
    {
      name: "doc",
      target: `${schema.resourceMetadata[0].SwaggerModelName}.properties`,
      arguments: [generateDocsContent({ doc: propertiesModel?.language.default.description })],
    },
  ];
}

function buildKeyProperty(schema: ArmResourceSchema): TypespecSpreadStatement {
  let decorators;
  let namePattern;
  let keyName;
  let type = "string";
  let doc;
  const segmentName = schema.resourceMetadata[0].ResourceKeySegment;
  if (!schema.resourceMetadata[0].IsSingletonResource) {
    const keyProperty = getKeyParameter(schema.resourceMetadata[0]);
    if (keyProperty === undefined) {
      logger().error(
        `Failed to find key property ${schema.resourceMetadata[0].ResourceKey} for ${schema.language.default.name}`,
      );
    }
    decorators = getPropertyDecorators(keyProperty!);
    namePattern = decorators.find((d) => d.name === "pattern")?.arguments?.[0];
    keyName = schema.resourceMetadata[0].ResourceKey;

    const codeModel = getSession().model;
    const dataTypes = getDataTypes(codeModel);
    const visited = dataTypes.get(keyProperty!.schema) ?? transformDataType(keyProperty!.schema, codeModel);
    type = visited.name;

    doc = keyProperty!.language.default.description;
  } else {
    keyName = singular(schema.resourceMetadata[0].ResourceKeySegment);
  }

  const keyProperty: TypespecSpreadStatement = {
    kind: "spread",
    model: {
      kind: "template",
      name: "ResourceNameParameter",
      namedArguments: { Resource: schema.resourceMetadata[0].SwaggerModelName },
    },
    decorators,
    doc,
  };
  if (keyName) keyProperty.model.namedArguments!["KeyName"] = `"${keyName}"`;
  if (segmentName) keyProperty.model.namedArguments!["SegmentName"] = `"${segmentName}"`;
  if (namePattern !== "^[a-zA-Z0-9-]{3,24}$")
    keyProperty.model.namedArguments!["NamePattern"] = (namePattern as string) ? `"${namePattern}"` : `""`;
  if (type !== "string") keyProperty.model.namedArguments!["Type"] = `${type}`;

  return keyProperty;
}

function buildResourceDecorators(schema: ArmResourceSchema): TypespecDecorator[] {
  const resourceModelDecorators: TypespecDecorator[] = [];

  if (schema.resourceMetadata[0].IsSingletonResource) {
    resourceModelDecorators.push({
      name: "singleton",
      arguments: [getSingletonName(schema)],
    });
  }

  if (schema.resourceMetadata[0].IsTenantResource) {
    resourceModelDecorators.push({
      name: "tenantResource",
    });
  } else if (schema.resourceMetadata[0].IsSubscriptionResource) {
    resourceModelDecorators.push({
      name: "subscriptionResource",
    });
  }

  return resourceModelDecorators;
}

function buildResourceClientDecorators(schema: ArmResourceSchema): TypespecDecorator[] {
  const clientDecorator: TypespecDecorator[] = [];
  if (schema.language.csharp?.name) {
    clientDecorator.push(createCSharpNameDecorator(schema));
  }

  return clientDecorator;
}

function getSingletonName(schema: ArmResourceSchema): string {
  const key = schema.resourceMetadata[0].ResourceKey;
  const pathLast = schema.resourceMetadata[0].GetOperation!.Path.split("/").pop() ?? "";
  if (key !== pathLast) {
    if (pathLast?.includes("{")) {
      // this is from c# config, which need confirm with service
      return "default";
    } else {
      return pathLast;
    }
  }
  return key;
}

function getLocationParent(schema: ArmResourceSchema): string | undefined {
  if (schema.resourceMetadata[0].GetOperation!.Path.includes("/locations/")) {
    if (schema.resourceMetadata[0].IsTenantResource) {
      return "TenantLocationResource";
    } else if (schema.resourceMetadata[0].IsSubscriptionResource) {
      return "SubscriptionLocationResource";
    } else if (schema.resourceMetadata[0].Parents?.[0] === "ResourceGroupResource") {
      return "ResourceGroupLocationResource";
    }
  }
}
