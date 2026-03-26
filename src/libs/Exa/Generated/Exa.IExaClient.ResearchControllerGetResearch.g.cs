#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Get a research request by id<br/>
        /// Retrieve research by ID. Add ?stream=true for real-time SSE updates.
        /// </summary>
        /// <param name="researchId"></param>
        /// <param name="stream"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ResearchDtoClass> ResearchControllerGetResearchAsync(
            string researchId,
            string stream,
            string events,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}