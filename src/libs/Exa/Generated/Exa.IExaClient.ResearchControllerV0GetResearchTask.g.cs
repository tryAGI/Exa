#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Get a research task by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ResearchTaskDto> ResearchControllerV0GetResearchTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}