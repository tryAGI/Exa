#nullable enable

namespace Exa
{
    public partial interface IEnrichmentsClient
    {
        /// <summary>
        /// Cancel a running Enrichment<br/>
        /// All running enrichments will be canceled. You can not resume an Enrichment after it has been canceled.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const enrichment = await exa.websets.enrichments.cancel("webset_id", "enrichment_id");<br/>
        /// console.log(`Cancelled enrichment: ${enrichment.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetEnrichment> WebsetsEnrichmentsCancelAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a running Enrichment<br/>
        /// All running enrichments will be canceled. You can not resume an Enrichment after it has been canceled.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const enrichment = await exa.websets.enrichments.cancel("webset_id", "enrichment_id");<br/>
        /// console.log(`Cancelled enrichment: ${enrichment.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetEnrichment>> WebsetsEnrichmentsCancelAsResponseAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}