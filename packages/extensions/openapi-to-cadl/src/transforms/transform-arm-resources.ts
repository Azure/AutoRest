import { CodeModel, HttpMethod, Operation, Parameter, Response, SchemaResponse } from "@autorest/codemodel";
import { lowerFirst } from "lodash";
import pluralize from "pluralize";
import { getSession } from "../autorest-session";
import { generateParameters } from "../generate/generate-operations";
import {
  ArmResourceKind,
  CadlDecorator,
  CadlObjectProperty,
  CadlParameter,
  MSIType,
  TspArmResource,
  TspArmResourceOperation,
} from "../interfaces";
import { getHttpMethod } from "../utils/operations";
import {
  ArmResource,
  ArmResourceSchema,
  _ArmResourceOperation,
  getArmResourcesMetadata,
  getResourceOperations,
  isResourceSchema,
} from "../utils/resource-discovery";
import { isResponseSchema } from "../utils/schemas";
import { transformParameter } from "./transform-operations";

const resourceParameters = ["subscriptionId", "resourceGroupName", "resourceName"];

export function transformTspArmResource(codeModel: CodeModel, schema: ArmResourceSchema): TspArmResource {
  let parameter;
  if (!schema.resourceMetadata.IsSingletonResource) {
    const keyProperty = getKeyParameter(codeModel, schema.resourceMetadata);
    if (!keyProperty) {
      throw new Error(
        `Failed to find key property ${schema.resourceMetadata.ResourceKey} for ${schema.language.default.name}`,
      );
    }
    parameter = transformParameter(keyProperty, codeModel);
  } else {
    parameter = generateSingletonKeyParameter();
  }

  decorateKeyProperty(parameter, schema);

  const resourceParent = getParentResourceSchema(codeModel, schema);

  const prop: CadlObjectProperty = { ...parameter, kind: "property" };

  const resourceModelDecorators: CadlDecorator[] = [];

  if (schema.resourceMetadata.Parents && schema.resourceMetadata.Parents.length > 0) {
    if (schema.resourceMetadata.Parents[0] !== "ResourceGroupResource") {
      resourceModelDecorators.push({
        name: "parentResource",
        arguments: [{ value: schema.resourceMetadata.Parents[0], options: { unwrap: true } }],
      });
    }
  }

  if (schema.resourceMetadata.IsSingletonResource) {
    resourceModelDecorators.push({
      name: "singleton",
      arguments: [schema.resourceMetadata.ResourceKey],
    });
  }

  const propertiesProperty = schema.properties?.find((p) => p.language.default.name === "properties");

  if (!propertiesProperty) {
    throw new Error(`Failed to find properties property for ${schema.language.default.name}`);
  }

  let msiType: MSIType | undefined;
  if (schema.properties?.find((p) => p.schema.language.default.name === "ManagedServiceIdentity")) {
    msiType = "ManagedServiceIdentity";
  } else if (schema.properties?.find((p) => p.schema.language.default.name === "SystemAssignedServiceIdentity")) {
    msiType = "ManagedSystemAssignedIdentity";
  }

  const propertiesName = propertiesProperty.schema.language.default.name;
  return {
    resourceKind: getResourceKind(schema),
    kind: "object",
    properties: [prop],
    name: schema.resourceMetadata.Name,
    parents: [],
    resourceParent,
    propertiesModelName: propertiesName,
    doc: schema.language.default.description,
    decorators: resourceModelDecorators,
    operations: getTspOperations(schema),
    msiType,
  };
}

function getTspOperations(armSchema: ArmResourceSchema): TspArmResourceOperation[] {
  const resourceMetadata = armSchema.resourceMetadata;
  const operations = getResourceOperations(resourceMetadata);
  const tspOperations: TspArmResourceOperation[] = [];
  for (const operation of operations) {
    const operationMetadata = resourceMetadata.Operations.find((o) => o.OperationID === operation.operationId);
    let baseParameters = operation ? getOperationParameters(operation, armSchema.resourceMetadata) : "";
    const okResponse = operation?.responses?.filter((o) => o.protocol.http?.statusCodes.includes("200"))?.[0];

    const operationResponse = operation?.responses?.[0];
    let operationResponseName: string = resourceMetadata.Name;
    if (operationResponse && isResponseSchema(operationResponse)) {
      if (!operationResponse.schema.language.default.name.includes("·")) {
        operationResponseName = operationResponse.schema.language.default.name;
      }
    }

    if (!operationMetadata) {
      if (resourceMetadata.IsSingletonResource) {
        tspOperations.push({
          doc: operation.language.default.description,
          kind: "ArmResourceListByParent",
          name: `listBy${resourceMetadata.Parents[0].replace(/Resource$/, "")}`,
          templateParameters: [resourceMetadata.Name],
          resultSchemaName: getSchemaResponseSchemaName(okResponse),
        });
        continue;
      }
      continue;
    }

    if (operationMetadata.OperationID.endsWith("_Get")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: "ArmResourceRead",
        name: "get",
        templateParameters: [resourceMetadata.Name],
      });
      continue;
    }

    if (operationMetadata.OperationID.endsWith("_ListByResourceGroup")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: "ArmResourceListByParent",
        name: "listByResourceGroup",
        templateParameters: [resourceMetadata.Name],
        resultSchemaName: getSchemaResponseSchemaName(okResponse),
      });
      continue;
    }

    if (operationMetadata.OperationID.endsWith("_ListBySubscription")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: "ArmListBySubscription",
        name: "listBySubscription",
        templateParameters: [resourceMetadata.Name],
        resultSchemaName: getSchemaResponseSchemaName(okResponse),
      });
      continue;
    }

    if (
      resourceMetadata.Parents.length &&
      operationMetadata.OperationID.includes("_ListBy")
    ) {
      const templateParameters = [resourceMetadata.Name];
      if (baseParameters) {
        templateParameters.push(baseParameters);
      }
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: "ArmResourceListByParent",
        name: `listBy${resourceMetadata.Parents[0]}`,
        templateParameters,
        resultSchemaName: getSchemaResponseSchemaName(okResponse),
      });
      continue;
    }

    if (operationMetadata.OperationID.endsWith("_CreateOrUpdate")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: operationMetadata.IsLongRunning ? "ArmResourceCreateOrUpdateAsync" : "ArmResourceCreateOrUpdateSync",
        name: "createOrUpdate",
        templateParameters: [resourceMetadata.Name],
      });
      continue;
    }

    if (operationMetadata.Method === "PUT" && operationMetadata.OperationID.endsWith("_Create")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: operationMetadata.IsLongRunning ? "ArmResourceCreateOrUpdateAsync" : "ArmResourceCreateOrUpdateSync",
        name: "create",
        templateParameters: [resourceMetadata.Name],
      });
      continue;
    }

    if (operationMetadata.OperationID.endsWith("_Update")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: operationMetadata.IsLongRunning ? "ArmResourcePatchAsync" : "ArmResourcePatchSync",
        name: "update",
        templateParameters: [resourceMetadata.Name, `${resourceMetadata.Name}Properties`],
      });
      continue;
    }

    if (operationMetadata.OperationID.endsWith("_Delete")) {
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: operationMetadata.IsLongRunning ? (okResponse ? "ArmResourceDeleteAsync" : "ArmResourceDeleteWithoutOkAsync") : "ArmResourceDeleteSync",
        name: "delete",
        templateParameters: [resourceMetadata.Name],
      });
      continue;
    }

    if (operationMetadata.Method === "PATCH") {
      const bodyParam = operation?.requests?.[0].parameters?.find((p) => p.protocol.http?.in === "body");
      const operationName = operationMetadata.OperationID.split("_")[1];
      tspOperations.push({
        doc: operationMetadata.Description,
        kind: operationMetadata.IsLongRunning ? "ArmCustomPatchAsync" : "ArmCustomPatchSync",
        name: operationName[0].toLowerCase() + operationName.slice(1),
        templateParameters: [resourceMetadata.Name, bodyParam?.schema.language.default.name ?? "{}"],
      });
      continue;
    }

    const operationName = operationMetadata.OperationID.replace(`${pluralize(resourceMetadata.Name)}_`, "");
    const fixMe: string[] = [];

    if (!baseParameters) {
      fixMe.push(
        "// FIXME: (ArmResourceAction): ArmResourceActionSync/ArmResourceActionAsync should have a body parameter",
      );
      baseParameters = "{}";
    }
    tspOperations.push({
      fixMe,
      doc: operationMetadata.Description,
      kind: `ArmResourceAction${okResponse ? "" : "NoContent"}${operationMetadata.IsLongRunning ? "Async" : "Sync"}` as any,
      name: lowerFirst(operationName),
      templateParameters: okResponse ? [resourceMetadata.Name, baseParameters, operationResponseName] : [resourceMetadata.Name, baseParameters],
    });
    continue;
  }

  return tspOperations;
}

function getOperationParameters(operation: Operation, resource: ArmResource): string {
  const codeModel = getSession().model;
  const parameters: CadlParameter[] = [];
  if (operation.parameters) {
    for (const parameter of operation.parameters) {
      if (
        !resourceParameters.includes(parameter.language.default.name) &&
        !parameter.origin?.startsWith("modelerfour:synthesized") &&
        !isParentIdPrameter(parameter, resource)
      ) {
        parameters.push(transformParameter(parameter, codeModel));
      }
    }
  }

  if (getHttpMethod(codeModel, operation) === HttpMethod.Post) {
    const bodyParam: Parameter | undefined = operation.requests?.[0].parameters?.find(
      (p) => p.protocol.http?.in === "body",
    );
    if (bodyParam) {
      const transformed = transformParameter(bodyParam, codeModel);
      parameters.push(transformed);
    }
  }

  return generateParameters(parameters);
}

function isParentIdPrameter(parameter: Parameter, resource: ArmResource): boolean {
  if (!resource.IsSingletonResource) {
    const codeModel = getSession().model;
    const selfKey = getKeyParameter(codeModel, resource);

    if (selfKey.language.default.name === parameter.language.default.name) {
      return true;
    }
  }

  const parent = getArmResourcesMetadata()[resource.Parents[0]];

  if (!parent) {
    return false;
  }

  return isParentIdPrameter(parameter, parent);
}

function getKeyParameter(codeModel: CodeModel, resourceMetadata: ArmResource): Parameter {
  const getOperation = resourceMetadata.Operations.find((o) => o.Method === "GET");
  if (!getOperation) {
    throw new Error(`Failed to find GET operation for ${resourceMetadata.Name}`);
  }

  for (const operationGroup of codeModel.operationGroups) {
    for (const operation of operationGroup.operations) {
      if (!operation.parameters) {
        throw new Error(`Failed to find parameters for ${operation.operationId}`);
      }

      for (const parameter of operation.parameters) {
        if (parameter.language.default.name === resourceMetadata.ResourceKey) {
          return parameter;
        }
      }
    }
  }

  throw new Error(`Failed to find operation for ${getOperation.OperationID}`);
}

function generateSingletonKeyParameter(): CadlParameter {
  return {
    kind: "parameter",
    name: "name",
    isOptional: false,
    type: "string",
    location: "path",
    serializedName: "name",
  };
}

function getParentResourceSchema(codeModel: CodeModel, schema: ArmResourceSchema): TspArmResource | undefined {
  const resourceParent = schema.resourceMetadata.Parents?.[0];

  if (!resourceParent) {
    return undefined;
  }

  for (const objectSchema of codeModel.schemas.objects ?? []) {
    if (!isResourceSchema(objectSchema)) {
      continue;
    }

    if (objectSchema.resourceMetadata.Name === resourceParent) {
      return transformTspArmResource(codeModel, objectSchema);
    }
  }
}

function decorateKeyProperty(property: CadlParameter, schema: ArmResourceSchema): void {
  if (!property.decorators) {
    property.decorators = [];
  }

  property.decorators.push(
    {
      name: "key",
      arguments: [schema.resourceMetadata.ResourceKey],
    },
    {
      name: "segment",
      arguments: [schema.resourceMetadata.ResourceKeySegment],
    },
  );

  // By convention the property itself needs to be called "name"
  property.name = "name";
}

function getResourceKind(schema: ArmResourceSchema): ArmResourceKind {
  if (schema.resourceMetadata.IsTrackedResource) {
    return "TrackedResource";
  }

  return "ProxyResource";
}

function getSchemaResponseSchemaName(response: Response | undefined): string | undefined {
  if (!response || !(response as SchemaResponse).schema) {
    return undefined;
  }

  return (response as SchemaResponse).schema.language.default.name;
}
