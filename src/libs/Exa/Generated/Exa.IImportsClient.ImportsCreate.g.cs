#nullable enable

namespace Exa
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// Create an Import<br/>
        /// Creates an Import for your own data. Upload the file to the returned `uploadUrl` before `uploadValidUntil`, 1 hour after creation. Use an Import to enrich its records, to search within them with `scope`, or to leave them out of searches with `exclude`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.CreateImportResponse> ImportsCreateAsync(

            global::Exa.CreateImportParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Import<br/>
        /// Creates an Import for your own data. Upload the file to the returned `uploadUrl` before `uploadValidUntil`, 1 hour after creation. Use an Import to enrich its records, to search within them with `scope`, or to leave them out of searches with `exclude`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.CreateImportResponse>> ImportsCreateAsResponseAsync(

            global::Exa.CreateImportParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Import<br/>
        /// Creates an Import for your own data. Upload the file to the returned `uploadUrl` before `uploadValidUntil`, 1 hour after creation. Use an Import to enrich its records, to search within them with `scope`, or to leave them out of searches with `exclude`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.CreateImportResponse> ImportsCreateAsync(
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}