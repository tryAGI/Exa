#nullable enable

namespace Exa
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Create a run<br/>
        /// Create an asynchronous Agent run. By default, the API returns the run object immediately. Set `Accept: text/event-stream` to stream run lifecycle events until the run reaches a terminal status.
        /// </summary>
        /// <param name="accept">
        /// Set to `text/event-stream` to receive server-sent events.
        /// </param>
        /// <param name="exaBeta">
        /// Comma-separated beta feature tokens for opting into experimental features.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.exa.ai/agent/runs \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{ ... }'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.AgentRunEvent> CreateAgentRunAsStreamAsync(

            global::Exa.CreateAgentRunRequest request,
            global::Exa.CreateAgentRunAccept? accept = default,
            string? exaBeta = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a run<br/>
        /// Create an asynchronous Agent run. By default, the API returns the run object immediately. Set `Accept: text/event-stream` to stream run lifecycle events until the run reaches a terminal status.
        /// </summary>
        /// <param name="accept">
        /// Set to `text/event-stream` to receive server-sent events.
        /// </param>
        /// <param name="exaBeta">
        /// Comma-separated beta feature tokens for opting into experimental features.
        /// </param>
        /// <param name="query">
        /// Natural-language question or instructions for the request.
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.
        /// </param>
        /// <param name="effort">
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort. `ultra` is the highest-effort tier for work where completeness and thoroughness matter more than latency or cost, including large list building, deep multi-source research, and criteria that are hard to verify.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="input">
        /// Records to process and records or entities to exclude from the answer.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="previousRunId">
        /// Completed run ID to continue from. Must belong to the same team.
        /// </param>
        /// <param name="metadata">
        /// Caller-provided metadata stored with the run.
        /// </param>
        /// <param name="dataSources">
        /// Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.
        /// </param>
        /// <param name="budget">
        /// Optional per-run spending and duration limits for the metered `auto` and `ultra` efforts. Runs that finish early may cost less than the limit.
        /// </param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.AgentRunEvent> CreateAgentRunAsStreamAsync(
            string query,
            global::Exa.CreateAgentRunAccept? accept = default,
            string? exaBeta = default,
            string? systemPrompt = default,
            global::Exa.AgentEffort? effort = default,
            global::Exa.CreateAgentRunRequestInput? input = default,
            global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? outputSchema = default,
            string? previousRunId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? dataSources = default,
            global::Exa.AgentBudget? budget = default,
            string? userIdentifier = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}