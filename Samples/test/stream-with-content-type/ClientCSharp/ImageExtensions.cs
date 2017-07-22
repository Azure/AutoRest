// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace StreamWithContentType
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Image.
    /// </summary>
    public static partial class ImageExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='imageContentType'>
            /// The content type of the image. Possible values include: 'image/gif',
            /// 'image/jpeg', 'image/png', 'image/bmp', 'image/tiff'
            /// </param>
            public static void A(this IImage operations, Stream image, ContentType? imageContentType = default(ContentType?))
            {
                operations.AAsync(image, imageContentType).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='imageContentType'>
            /// The content type of the image. Possible values include: 'image/gif',
            /// 'image/jpeg', 'image/png', 'image/bmp', 'image/tiff'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AAsync(this IImage operations, Stream image, ContentType? imageContentType = default(ContentType?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AWithHttpMessagesAsync(image, imageContentType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='imageContentType'>
            /// The content type of the image. Possible values include: 'image/gif',
            /// 'image/jpeg', 'image/png', 'image/bmp', 'image/tiff'
            /// </param>
            public static void B(this IImage operations, Stream image, ContentType imageContentType)
            {
                operations.BAsync(image, imageContentType).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='imageContentType'>
            /// The content type of the image. Possible values include: 'image/gif',
            /// 'image/jpeg', 'image/png', 'image/bmp', 'image/tiff'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BAsync(this IImage operations, Stream image, ContentType imageContentType, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BWithHttpMessagesAsync(image, imageContentType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
