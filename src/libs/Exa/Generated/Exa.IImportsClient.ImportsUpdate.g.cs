#nullable enable

namespace Exa
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// Update Import<br/>
        /// Updates a import configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const importJob = await exa.websets.imports.update("webset_id", "import_id", {<br/>
        ///   name: "Updated Import Name",<br/>
        /// });<br/>
        /// console.log(`Updated import: ${importJob.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Import> ImportsUpdateAsync(
            string id,

            global::Exa.UpdateImport request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Import<br/>
        /// Updates a import configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const importJob = await exa.websets.imports.update("webset_id", "import_id", {<br/>
        ///   name: "Updated Import Name",<br/>
        /// });<br/>
        /// console.log(`Updated import: ${importJob.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Import>> ImportsUpdateAsResponseAsync(
            string id,

            global::Exa.UpdateImport request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Import<br/>
        /// Updates a import configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="title"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Import> ImportsUpdateAsync(
            string id,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? title = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}