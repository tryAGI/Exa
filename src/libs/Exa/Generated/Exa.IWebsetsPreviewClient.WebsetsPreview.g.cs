#nullable enable

namespace Exa
{
    public partial interface IWebsetsPreviewClient
    {
        /// <summary>
        /// Preview a webset<br/>
        /// Returns how a search query will be interpreted before you create a Webset, including the detected entity, generated criteria, and suggested enrichments.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.PreviewWebsetResponse> WebsetsPreviewAsync(

            global::Exa.PreviewWebsetParameters request,
            bool? search = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview a webset<br/>
        /// Returns how a search query will be interpreted before you create a Webset, including the detected entity, generated criteria, and suggested enrichments.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.PreviewWebsetResponse>> WebsetsPreviewAsResponseAsync(

            global::Exa.PreviewWebsetParameters request,
            bool? search = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview a webset<br/>
        /// Returns how a search query will be interpreted before you create a Webset, including the detected entity, generated criteria, and suggested enrichments.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="requestSearch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.PreviewWebsetResponse> WebsetsPreviewAsync(
            global::Exa.PreviewWebsetParametersSearch requestSearch,
            bool? search = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}