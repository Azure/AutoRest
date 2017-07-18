// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ApplicationGateway
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PacketCapturesOperations.
    /// </summary>
    public static partial class PacketCapturesOperationsExtensions
    {
            /// <summary>
            /// Create and start a packet capture on the specified VM.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the create packet capture operation.
            /// </param>
            public static PacketCaptureResult Create(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCapture parameters)
            {
                return operations.CreateAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create and start a packet capture on the specified VM.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the create packet capture operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureResult> CreateAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCapture parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a packet capture session by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            public static PacketCaptureResult Get(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                return operations.GetAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a packet capture session by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureResult> GetAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            public static void Delete(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                operations.DeleteAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops a specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            public static void Stop(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                operations.StopAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops a specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Query the status of a running packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name given to the packet capture session.
            /// </param>
            public static PacketCaptureQueryStatusResult GetStatus(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                return operations.GetStatusAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query the status of a running packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name given to the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureQueryStatusResult> GetStatusAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatusWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all packet capture sessions within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            public static IEnumerable<PacketCaptureResult> List(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName)
            {
                return operations.ListAsync(resourceGroupName, networkWatcherName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all packet capture sessions within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PacketCaptureResult>> ListAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkWatcherName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create and start a packet capture on the specified VM.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the create packet capture operation.
            /// </param>
            public static PacketCaptureResult BeginCreate(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCapture parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create and start a packet capture on the specified VM.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the create packet capture operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureResult> BeginCreateAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCapture parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            public static void BeginDelete(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                operations.BeginDeleteAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops a specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            public static void BeginStop(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                operations.BeginStopAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops a specified packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name of the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Query the status of a running packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name given to the packet capture session.
            /// </param>
            public static PacketCaptureQueryStatusResult BeginGetStatus(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName)
            {
                return operations.BeginGetStatusAsync(resourceGroupName, networkWatcherName, packetCaptureName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query the status of a running packet capture session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='packetCaptureName'>
            /// The name given to the packet capture session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PacketCaptureQueryStatusResult> BeginGetStatusAsync(this IPacketCapturesOperations operations, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetStatusWithHttpMessagesAsync(resourceGroupName, networkWatcherName, packetCaptureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
