#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Create a research task with instructions and an output schema
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ResearchTasksCreateResponse> ResearchTasksCreateAsync(

            global::Exa.ResearchTasksCreateRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a research task with instructions and an output schema
        /// </summary>
        /// <param name="instructions">
        /// Instructions for what the research task should accomplish
        /// </param>
        /// <param name="model">
        /// Default Value: exa-research
        /// </param>
        /// <param name="output"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ResearchTasksCreateResponse> ResearchTasksCreateAsync(
            string instructions,
            global::Exa.ResearchTasksCreateRequestModel? model = default,
            global::Exa.ResearchTasksCreateRequestOutput? output = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}