#nullable enable

namespace Exa
{
    public partial interface IEnrichmentsClient
    {
        /// <summary>
        /// Create an Enrichment<br/>
        /// Create an Enrichment for a Webset.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const enrichment = await exa.websets.enrichments.create("webset_id", {<br/>
        ///   description: "Company revenue information",<br/>
        ///   format: "text",<br/>
        /// });<br/>
        /// console.log(`Created enrichment: ${enrichment.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetEnrichment> WebsetsEnrichmentsCreateAsync(
            string webset,

            global::Exa.CreateEnrichmentParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Enrichment<br/>
        /// Create an Enrichment for a Webset.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const enrichment = await exa.websets.enrichments.create("webset_id", {<br/>
        ///   description: "Company revenue information",<br/>
        ///   format: "text",<br/>
        /// });<br/>
        /// console.log(`Created enrichment: ${enrichment.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetEnrichment>> WebsetsEnrichmentsCreateAsResponseAsync(
            string webset,

            global::Exa.CreateEnrichmentParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Enrichment<br/>
        /// Create an Enrichment for a Webset.
        /// </summary>
        /// <param name="webset"></param>
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
        global::System.Threading.Tasks.Task<global::Exa.WebsetEnrichment> WebsetsEnrichmentsCreateAsync(
            string webset,
            string description,
            global::Exa.CreateEnrichmentParametersFormat? format = default,
            global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>? options = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}