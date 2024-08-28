import { ArraySchema, isObjectSchema, Operation, SchemaResponse } from "@autorest/codemodel";
import { getResourceDataSchema, OperationSet } from "./operation-set";
import { ManagementGroupPath, ManagementGroupScopePrefix, ProvidersSegment, ResourceGroupPath, ResourceGroupScopePrefix, SubscriptionPath, SubscriptionScopePrefix, TenantPath, TenantScopePrefix } from "./constants";
import { isArraySchema, isResponseSchema } from "../utils/schemas";
import { getResourceType, getScopePath, isScopedSegment, pathIncludes } from "./utils";
import { getPagingItemType } from "./resource-equivalent";

const extensionMethodCache = new WeakMap<OperationSet, [Operation, string][]>();
const resourceCollectionMethodCache = new WeakMap<OperationSet, Operation[]>();
const otherOperationCache = new WeakMap<OperationSet, Operation[]>();

export function setParentOfResourceCollectionOperation(operation: Operation, requestPath: string, operationSets: OperationSet[]): boolean {
    // first we need to ensure this operation at least returns a collection of something
    const itemType = getPagingItemType(operation);
    if (itemType === undefined) return false;

    // then check if its path is a prefix of which resource's operationSet
    // if there are multiple resources that share the same prefix of request path, we choose the shortest one
    const requestScopeType = getScopeResourceType(requestPath);
    const candidates: OperationSet[] = [];
    for (const operationSet of operationSets) {
        const resourceRequestPath = operationSet.RequestPath;
        const resourceScopeType = getScopeResourceType(resourceRequestPath);

        if (!pathIncludes(resourceScopeType, requestScopeType) && !resourceScopeType.includes("*")) continue;

        const providerIndexOfResource = resourceRequestPath.lastIndexOf(ProvidersSegment);
        const providerIndexOfRequest = requestPath.lastIndexOf(ProvidersSegment);
        const trimmedResourceRequestPath = resourceRequestPath.substring(providerIndexOfResource);
        const trimmedRequestPath = requestPath.substring(providerIndexOfRequest);

        if (!pathIncludes(trimmedResourceRequestPath, trimmedRequestPath)) continue;
        if (getResourceDataSchema(operationSet) !== itemType) continue;

        candidates.push(operationSet);
    }

    if (candidates.length === 0) return false;
    const bestOne = candidates.sort((a, b) => b.RequestPath.split("/").length - a.RequestPath.split("/").length)[0];

    if (resourceCollectionMethodCache.has(bestOne)) {
        resourceCollectionMethodCache.get(bestOne)!.push(operation);
    }
    else {
        resourceCollectionMethodCache.set(bestOne, [operation]);
    }
    return true;
}

export function getResourceCollectionOperations(set: OperationSet): Operation[] {
    return resourceCollectionMethodCache.get(set) ?? [];
}

export function setParentOfOtherOperation(operation: Operation, requestPath: string, operationSets: OperationSet[]): boolean {
    const candidates: OperationSet[] = operationSets.filter(o => pathIncludes(requestPath, o.RequestPath));
    if (candidates.length === 0) return false;

    const bestOne = candidates.sort((a, b) => b.RequestPath.split("/").length - a.RequestPath.split("/").length)[0];
    if (otherOperationCache.has(bestOne)) {
        otherOperationCache.get(bestOne)!.push(operation);
    }
    else {
        otherOperationCache.set(bestOne, [operation]);
    }

    return true;
}

export function getOtherOperations(set: OperationSet): Operation[] {
    return otherOperationCache.get(set) ?? [];
}

export function setParentOfExtensionOperation(operation: Operation, requestPath: string, operationSets: OperationSet[]): boolean {
    const itemType = getPagingItemType(operation);
    if (itemType === undefined) return false;
    
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
        if (!pathIncludes(trimmedResourceRequestPath, trimmedRequestPath)) continue;
        if (getResourceDataSchema(operationSet) !== itemType) continue;

        candidates.push(operationSet);
    }

    if (candidates.length === 0) return false;
    const bestOne = candidates.sort((a, b) => a.RequestPath.split("/").length - b.RequestPath.split("/").length)[0];

    if (extensionMethodCache.has(bestOne)) {
        extensionMethodCache.get(bestOne)!.push([operation, extensionType]);
    }
    else {
        extensionMethodCache.set(bestOne, [[operation, extensionType]]);
    }
    return true;
}

export function getExtensionOperation(set: OperationSet): [Operation, string][] {
    return extensionMethodCache.get(set) ?? [];
}

export function getParents(requestPath: string, operationSets: OperationSet[]): string[] {
    let segments = requestPath.split("/");
    if (segments.length < 2) return ["ArmResource"];

    segments = segments.slice(0, -2);
    if (segments.length < 2) return ["ArmResource"];

    if (segments[segments.length - 2] === "providers") segments = segments.slice(0, -2);
    const parentPath = segments.join("/");
    if (parentPath === ResourceGroupPath) return ["ResourceGroupResource"];
    if (parentPath === SubscriptionPath) return ["SubscriptionResource"];
    if (parentPath === TenantPath) return ["TenantResource"];
    const operationSet = operationSets.find(set => set.RequestPath === parentPath);
    if (operationSet === undefined) {
        return getParents(parentPath, operationSets);
    }
    return [getResourceDataSchema(operationSet!)!];
}

function getScopeResourceType(path: string): string {
    const scopePath = getScopePath(path);
    if (scopePath === SubscriptionPath) return "Microsoft.Resources/subscriptions";
    if (scopePath === ResourceGroupPath) return "Microsoft.Resources/resourceGroups";
    if (scopePath === ManagementGroupPath) return "Microsoft.Management/managementGroups";
    if (scopePath === TenantPath) return "Microsoft.Resources/tenants";
    if (isScopedSegment(scopePath)) return "*";

    return getResourceType(scopePath);
}