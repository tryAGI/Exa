#nullable enable

namespace Exa
{
    public partial interface IEnrichmentsClient
    {
        /// <summary>
        /// Update an Enrichment<br/>
        /// Update an Enrichment configuration for a Webset.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const enrichment = await exa.websets.enrichments.update("webset_id", "enrichment_id", {<br/>
        ///   description: "Updated company revenue and growth metrics",<br/>
        ///   format: "number",<br/>
        /// });<br/>
        /// console.log(`Updated enrichment: ${enrichment.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task WebsetsEnrichmentsUpdateAsync(
            string webset,
            string id,

            global::Exa.UpdateEnrichmentParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Enrichment<br/>
        /// Update an Enrichment configuration for a Webset.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const enrichment = await exa.websets.enrichments.update("webset_id", "enrichment_id", {<br/>
        ///   description: "Updated company revenue and growth metrics",<br/>
        ///   format: "number",<br/>
        /// });<br/>
        /// console.log(`Updated enrichment: ${enrichment.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse> WebsetsEnrichmentsUpdateAsResponseAsync(
            string webset,
            string id,

            global::Exa.UpdateEnrichmentParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Enrichment<br/>
        /// Update an Enrichment configuration for a Webset.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="description">
        /// Provide a description of the enrichment task you want to perform to each Webset Item.
        /// </param>
        /// <param name="format">
        /// Format of the enrichment response.<br/>
        /// We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.
        /// </param>
        /// <param name="options">
        /// When the format is options, the different options for the enrichment agent to choose from.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task WebsetsEnrichmentsUpdateAsync(
            string webset,
            string id,
            string? description = default,
            global::Exa.UpdateEnrichmentParametersFormat? format = default,
            global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>? options = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}