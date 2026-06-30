#nullable enable

namespace Exa
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// Create an Import<br/>
        /// Creates a new import to upload your data into Websets. Imports can be used to:<br/>
        /// - **Enrich**: Enhance your data with additional information using our AI-powered enrichment engine<br/>
        /// - **Search**: Query your data using Websets' agentic search with natural language filters<br/>
        /// - **Exclude**: Prevent duplicate or already known results from appearing in your searches<br/>
        /// Once the import is created, you can upload your data to the returned `uploadUrl` until `uploadValidUntil` (by default 1 hour).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const importJob = await exa.websets.imports.create("webset_id", {<br/>
        ///   source: {<br/>
        ///     type: "csv",<br/>
        ///     url: "https://example.com/companies.csv",<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(`Created import: ${importJob.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.CreateImportResponse> ImportsCreateAsync(

            global::Exa.CreateImportParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Import<br/>
        /// Creates a new import to upload your data into Websets. Imports can be used to:<br/>
        /// - **Enrich**: Enhance your data with additional information using our AI-powered enrichment engine<br/>
        /// - **Search**: Query your data using Websets' agentic search with natural language filters<br/>
        /// - **Exclude**: Prevent duplicate or already known results from appearing in your searches<br/>
        /// Once the import is created, you can upload your data to the returned `uploadUrl` until `uploadValidUntil` (by default 1 hour).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const importJob = await exa.websets.imports.create("webset_id", {<br/>
        ///   source: {<br/>
        ///     type: "csv",<br/>
        ///     url: "https://example.com/companies.csv",<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(`Created import: ${importJob.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.CreateImportResponse>> ImportsCreateAsResponseAsync(

            global::Exa.CreateImportParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Import<br/>
        /// Creates a new import to upload your data into Websets. Imports can be used to:<br/>
        /// - **Enrich**: Enhance your data with additional information using our AI-powered enrichment engine<br/>
        /// - **Search**: Query your data using Websets' agentic search with natural language filters<br/>
        /// - **Exclude**: Prevent duplicate or already known results from appearing in your searches<br/>
        /// Once the import is created, you can upload your data to the returned `uploadUrl` until `uploadValidUntil` (by default 1 hour).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.CreateImportResponse> ImportsCreateAsync(
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}