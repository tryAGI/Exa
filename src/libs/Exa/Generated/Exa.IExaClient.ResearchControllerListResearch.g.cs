#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// List research requests<br/>
        /// Get a paginated list of research requests
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListResearchResponseDto> ResearchControllerListResearchAsync(
            string? cursor = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}