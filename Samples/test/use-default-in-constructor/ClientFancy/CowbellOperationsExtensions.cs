// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace PropertyDefaults
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CowbellOperations.
    /// </summary>
    public static partial class CowbellOperationsExtensions
    {
            /// <summary>
            /// A good description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void Add(this ICowbellOperations operations, Cowbell body)
            {
                operations.AddAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// A good description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddAsync(this ICowbellOperations operations, Cowbell body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
