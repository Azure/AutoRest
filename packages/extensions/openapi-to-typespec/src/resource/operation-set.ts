import { ArraySchema, HttpMethod, isObjectSchema, Operation, SchemaResponse } from "@autorest/codemodel";
import { isArraySchema, isResponseSchema } from "../utils/schemas";
import { isResource } from "./resource-equivalent";

const ProvidersSegment = "/providers/";
const ManagementGroupPath = "/providers/Microsoft.Management/managementGroups/{managementGroupId}";
const ManagementGroupScopePrefix = "/providers/Microsoft.Management/managementGroups";
const ResourceGroupPath = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}";
const ResourceGroupScopePrefix = "/subscriptions/{subscriptionId}/resourceGroups";
const SubscriptionPath = "/subscriptions/{subscriptionId}";
const SubscriptionScopePrefix = "/subscriptions";
const TenantPath = "";
const TenantScopePrefix = "/tenants";

export interface OperationSet {
    RequestPath: string;
    Operations: Array<Operation>;
}

const resourceDataSchemaCache = new WeakMap<OperationSet, string | undefined>();
const extensionMethodCache = new WeakMap<OperationSet, [Operation, string][]>();

export function getParentOfLifeCycleOperation(requestPath: string, operationSets: OperationSet[]): string | undefined {
    const candidates: OperationSet[] = operationSets.filter(o => requestPath.includes(o.RequestPath));
    if (candidates.length === 0) return undefined;
    const bestOne = candidates.sort(c => c.RequestPath.split("/").length)[0];
    return bestOne.RequestPath;
}

export function getParentOfResourceCollectionOperation(operation: Operation, requestPath: string, operationSets: OperationSet[]): string | undefined {
    // first we need to ensure this operation at least returns a collection of something
    const itemType = getCollectionOperationItemType(operation);
    if (itemType === undefined) return undefined;

    // then check if its path is a prefix of which resource's operationSet
    // if there are multiple resources that share the same prefix of request path, we choose the shortest one
    const requestScopeType = getScopeResourceType(requestPath);
    const candidates: OperationSet[] = [];
    for (const operationSet of operationSets) {
        const resourceRequestPath = operationSet.RequestPath;
        const resourceScopeType = getScopeResourceType(resourceRequestPath);

        if (!resourceScopeType.includes(requestScopeType) && !requestScopeType.includes("*")) continue;

        const providerIndexOfResource = resourceRequestPath.lastIndexOf(ProvidersSegment);
        const providerIndexOfRequest = requestPath.lastIndexOf(ProvidersSegment);
        const trimmedResourceRequestPath = resourceRequestPath.substring(providerIndexOfResource);
        const trimmedRequestPath = requestPath.substring(providerIndexOfRequest);

        if (!trimmedResourceRequestPath.includes(trimmedRequestPath)) continue;
        if (getResourceDataSchema(operationSet) !== itemType) continue;

        candidates.push(operationSet);
    }

    if (candidates.length === 0) return undefined;
    const bestOne = candidates.sort((a, b) => a.RequestPath.split("/").length - b.RequestPath.split("/").length)[0];
    return bestOne.RequestPath;
}

export function setParentOfExtensionOperation(operation: Operation, requestPath: string, operationSets: OperationSet[]): void {
    const itemType = getCollectionOperationItemType(operation);
    if (itemType === undefined) return;
    
    const providerIndexOfRequest = requestPath.lastIndexOf(ProvidersSegment);
    const trimmedRequestPath = requestPath.substring(providerIndexOfRequest);

    let extensionType = "";
    switch (getScopePath(requestPath)) {
        case ResourceGroupPath:
            extensionType = "Resource";
            break;
        case SubscriptionPath:
            extensionType = "Subscription";
            break;
        case ManagementGroupPath:
            extensionType = "ManagementGroup";
            break;
        case TenantPath:
            extensionType = "Tenant";
            break;
    }

    const candidates: OperationSet[] = [];
    for (const operationSet of operationSets) {
        const resourceRequestPath = operationSet.RequestPath;

        const providerIndexOfResource = resourceRequestPath.lastIndexOf(ProvidersSegment);
        const trimmedResourceRequestPath = resourceRequestPath.substring(providerIndexOfResource);
        if (!trimmedResourceRequestPath.includes(trimmedRequestPath)) continue;
        if (getResourceDataSchema(operationSet) !== itemType) continue;

        candidates.push(operationSet);
    }

    if (candidates.length === 0) return;
    const bestOne = candidates.sort((a, b) => a.RequestPath.split("/").length - b.RequestPath.split("/").length)[0];

    if (extensionMethodCache.has(bestOne)) {
        extensionMethodCache.get(bestOne)!.push([operation, extensionType]);
    }
    else {
        extensionMethodCache.set(bestOne, [[operation, extensionType]]);
    }
}

export function getExtensionOperation(set: OperationSet): [Operation, string][] {
    return extensionMethodCache.get(set) ?? [];
}

function getScopeResourceType(path: string): string {
    const scopePath = getScopePath(path);
    if (scopePath === SubscriptionPath) return "Microsoft.Resources/subscriptions";
    if (scopePath === ResourceGroupPath) return "Microsoft.Resources/resourceGroups";
    if (scopePath === ManagementGroupPath) return "Microsoft.Management/managementGroups";
    if (scopePath === TenantPath) return "Microsoft.Resources/tenants";
    if (scopePath === "*") return "*";

    return getResourceType(scopePath);
}

export function getParents(set: OperationSet, operationSets: OperationSet[]): string[] {
    let segments = set.RequestPath.split("/");
    if (segments.length < 2) return [];

    segments = segments.slice(0, -2);
    if (segments.length < 2) return [];

    if (segments[segments.length - 2] === "providers") segments = segments.slice(0, -2);
    const parentPath = segments.join("/");
    if (parentPath === ResourceGroupPath) return ["ResourceGroupResource"];
    if (parentPath === SubscriptionPath) return ["SubscriptionResource"];
    if (parentPath === TenantPath) return ["TenantResource"];
    const operationSet = operationSets.find(set => set.RequestPath === parentPath);
    return [getResourceDataSchema(operationSet!)!];
}

export function getResourceType(path: string): string {
    const index = path.lastIndexOf(ProvidersSegment);
    if (index < 0 || path.substring(index + ProvidersSegment.length).includes("/") === false) {
        const pathToLower = path.toLowerCase();
        if (pathToLower.startsWith(ResourceGroupScopePrefix.toLowerCase())) return "Microsoft.Resources/resourceGroups";
        if (pathToLower.startsWith(SubscriptionScopePrefix.toLowerCase())) return "Microsoft.Resources/subscriptions";
        if (pathToLower.startsWith(TenantScopePrefix.toLowerCase())) return "Microsoft.Resources/tenants";
    }

    return path.substring(index + ProvidersSegment.length).split("/").reduce(
        (result, current, index) => {
            if (index === 0 || index % 2 === 1) return result === "" ? current : `${result}/${current}`;
            else return result;
        },
        ""
    );
}

export function getResourceKey(path: string): string {
    const segments = path.split("/");
    return segments[segments.length - 1].replace(/^\{(.+)\}$/,'$1');
}

export function getResourceKeySegment(path: string): string {
    const segments = path.split("/");
    return segments[segments.length - 2];
}

function getScopePath(path: string): string {
    const pathToLower = path.toLowerCase();

    const index = pathToLower.lastIndexOf(ProvidersSegment);
    if (index === 0 && pathToLower.startsWith(ManagementGroupScopePrefix.toLowerCase())) return ManagementGroupPath;
    if (index > 0) return path.slice(0, index);
    if (pathToLower.startsWith(ResourceGroupScopePrefix.toLowerCase())) return ResourceGroupPath;
    if (pathToLower.startsWith(SubscriptionScopePrefix.toLowerCase())) return SubscriptionPath
    if (pathToLower.startsWith(TenantScopePrefix.toLowerCase())) return TenantPath;

    return path;
}

function getCollectionOperationItemType(operation: Operation): string | undefined {
    const response = operation.responses?.find(r => isResponseSchema(r));
    if (response === undefined) return undefined;

    let itemName = "value";
    if (operation.extensions?.["x-ms-pageable"]?.itemName) {
        itemName = operation.extensions?.["x-ms-pageable"]?.itemName;
    }

    const schemaResponse = response as SchemaResponse;
    if (isArraySchema(schemaResponse.schema)) return schemaResponse.schema.elementType.language.default.name;
    if (isObjectSchema(schemaResponse.schema)) {
        const responseSchema = schemaResponse.schema.properties?.find(p => p.serializedName === itemName && isArraySchema(p.schema));
        if (!responseSchema) return undefined;
        return (responseSchema.schema as ArraySchema).elementType.language.default.name;
    }
    return undefined;
}

export function getResourceDataSchema(set: OperationSet): string | undefined {
    if (resourceDataSchemaCache.has(set)) return resourceDataSchemaCache.get(set);

    // Check if the request path has even number of segments after the providers segment
    if (!checkEvenSegments(set.RequestPath)) {
        resourceDataSchemaCache.set(set, undefined);
        return undefined;
    }

    // before we are finding any operations, we need to ensure this operation set has a GET request.
    if (findOperation(set, HttpMethod.Get) === undefined) {
        resourceDataSchemaCache.set(set, undefined);
        return undefined;
    }

    // try put operation to get the resource name
    let resourceSchemaName = getResourceSchemaName(set, HttpMethod.Put);
    if (resourceSchemaName !== undefined) {
        resourceDataSchemaCache.set(set, resourceSchemaName);
        return resourceSchemaName;
    }

    // try get operation to get the resource name
    resourceSchemaName = getResourceSchemaName(set, HttpMethod.Get);
    if (resourceSchemaName !== undefined) {
        resourceDataSchemaCache.set(set, resourceSchemaName);
        return resourceSchemaName;
    }

    // We tried everything, this is not a resource
    resourceDataSchemaCache.set(set, undefined);
    return undefined;
}

function checkEvenSegments(path: string): boolean {
    const index = path.lastIndexOf(ProvidersSegment);

    // this request path does not have providers segment - it can be a "ById" request, skip to next criteria
    if (index < 0) return true;

    // get whatever following the providers
    const following = path.substring(index);
    const segments = following.split("/").filter(s => s.length > 0);
    return segments.length % 2 === 0;
}

export function findOperation(set: OperationSet, method: HttpMethod): Operation | undefined {
    return set.Operations.find(o => o.requests![0].protocol.http?.method === method);
}

function getResourceSchemaName(set: OperationSet, method: HttpMethod): string | undefined {
    const operation = findOperation(set, method);
    if (operation === undefined) return undefined;

    // find the response with code 200
    const response = operation.responses?.find(r => r.protocol.http?.statusCodes.includes("200"));
    if (response === undefined) return undefined;

    // find the response schema
    if (!isResponseSchema(response) || !isObjectSchema(response.schema)) return undefined;

    // we need to verify this schema has ID, type and name so that this is a resource model
    if (!isResource(response.schema)) return undefined;

    return response.schema.language.default.name;
}

function getSingletonResourceSuffix(set: OperationSet): string | undefined {
    // return undefined if this is not a resource
    if (getResourceDataSchema(set) === undefined) return undefined;

    
}