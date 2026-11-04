// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Mcp.Tools.ResilienceManagement.Commands.Recovery.Plans;

/// <summary>
/// Azure resource types that Recovery Orchestration can protect in a recoveryplan.
/// Mirrors <c>ResourceProviderTypes.DefaultSupportedResourceTypes</c> in ResiliencyHub-RecoveryOrchestration
/// (src/ServiceUtility/ResourceProviderTypes.cs); keep both lists in sync.
/// </summary>
internal static class RecoveryPlanSupportedResourceTypes
{
    private static readonly HashSet<string> s_supportedResourceTypes = new(StringComparer.OrdinalIgnoreCase)
    {
        "Microsoft.ApiManagement/service",
        "Microsoft.App/managedEnvironments",
        "Microsoft.Cache/redis",
        "Microsoft.CognitiveServices/accounts",
        "Microsoft.Compute/cloudServices",
        "Microsoft.Compute/hostGroups",
        "Microsoft.Compute/virtualMachineScaleSets",
        "Microsoft.Compute/virtualMachines",
        "Microsoft.ContainerRegistry/registries",
        "Microsoft.ContainerRegistry/registries/replications",
        "Microsoft.ContainerService/managedClusters",
        "Microsoft.Dashboard/grafana",
        "Microsoft.DBforMySQL/flexibleServers",
        "Microsoft.DBforPostgreSQL/flexibleServers",
        "Microsoft.DBforPostgreSQL/serverGroupsv2",
        "Microsoft.DocumentDB/databaseAccounts",
        "Microsoft.EventHub/clusters",
        "Microsoft.EventHub/namespaces",
        "Microsoft.HDInsight/clusters",
        "Microsoft.KeyVault/vaults",
        "Microsoft.Kusto/clusters",
        "Microsoft.NetApp/netAppAccounts/capacityPools/volumes",
        "Microsoft.Network/applicationGateways",
        "Microsoft.Network/azureFirewalls",
        "Microsoft.Network/bastionHosts",
        "Microsoft.Network/loadBalancers",
        "Microsoft.Network/natGateways",
        "Microsoft.Network/publicIPAddresses",
        "Microsoft.Network/publicIPPrefixes",
        "Microsoft.Network/virtualNetworkGateways",
        "Microsoft.ServiceBus/namespaces",
        "Microsoft.ServiceFabric/clusters",
        "Microsoft.ServiceFabric/managedClusters",
        "Microsoft.SignalRService/webPubSub",
        "Microsoft.Sql/managedInstances",
        "Microsoft.Sql/servers/databases",
        "Microsoft.Sql/servers/elasticPools",
        "Microsoft.SqlVirtualMachine/sqlVirtualMachines",
        "Microsoft.Storage/storageAccounts",
        "Microsoft.Web/hostingEnvironments",
        "Microsoft.Web/serverFarms",
    };

    /// <summary>
    /// Gets the supported resource types.
    /// </summary>
    public static IReadOnlyCollection<string> All => s_supportedResourceTypes;

    /// <summary>
    /// Returns whether Recovery Orchestration can protect the given resource type.
    /// </summary>
    public static bool IsSupported(ResourceType resourceType) => s_supportedResourceTypes.Contains(resourceType.ToString());
}
