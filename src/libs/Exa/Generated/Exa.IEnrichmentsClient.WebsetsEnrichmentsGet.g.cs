#nullable enable

namespace Exa
{
    public partial interface IEnrichmentsClient
    {
        /// <summary>
        /// Get an Enrichment
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
        /// const enrichment = await exa.websets.enrichments.get("webset_id", "enrichment_id");<br/>
        /// console.log(`Enrichment: ${enrichment.id} - ${enrichment.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetEnrichment> WebsetsEnrichmentsGetAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an Enrichment
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
        /// const enrichment = await exa.websets.enrichments.get("webset_id", "enrichment_id");<br/>
        /// console.log(`Enrichment: ${enrichment.id} - ${enrichment.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetEnrichment>> WebsetsEnrichmentsGetAsResponseAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}