#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// List research tasks
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ResearchTasksListResponse> ResearchTasksListAsync(
            string? cursor = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}