#nullable enable

namespace Exa
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// List Imports<br/>
        /// Lists all imports for the Webset.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const imports = await exa.websets.imports.list({<br/>
        ///   webset_id: "webset_id",<br/>
        /// });<br/>
        /// console.log(`Found ${imports.data.length} imports`);<br/>
        /// imports.data.forEach((importJob) =&gt; {<br/>
        ///   console.log(`- ${importJob.id}: ${importJob.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListImportsResponse> ImportsListAsync(
            string? cursor = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Imports<br/>
        /// Lists all imports for the Webset.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const imports = await exa.websets.imports.list({<br/>
        ///   webset_id: "webset_id",<br/>
        /// });<br/>
        /// console.log(`Found ${imports.data.length} imports`);<br/>
        /// imports.data.forEach((importJob) =&gt; {<br/>
        ///   console.log(`- ${importJob.id}: ${importJob.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListImportsResponse>> ImportsListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}