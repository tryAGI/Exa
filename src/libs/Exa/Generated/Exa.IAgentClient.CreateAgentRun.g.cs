#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

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
        /// from exa_py import Exa<br/>
        /// exa = Exa(api_key="YOUR_EXA_API_KEY")<br/>
        /// run = exa.agent.runs.create(<br/>
        ///     query="What are the most important AI infrastructure funding rounds announced this week?",<br/>
        /// )<br/>
        /// print(run)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AgentRun> CreateAgentRunAsync(

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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// from exa_py import Exa<br/>
        /// exa = Exa(api_key="YOUR_EXA_API_KEY")<br/>
        /// run = exa.agent.runs.create(<br/>
        ///     query="What are the most important AI infrastructure funding rounds announced this week?",<br/>
        /// )<br/>
        /// print(run)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.AgentRun>> CreateAgentRunAsResponseAsync(

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
        /// Natural-language question or instructions for the request.<br/>
        /// Example: What are the most important AI infrastructure funding rounds announced this week?
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.<br/>
        /// Example: Prefer official sources and avoid duplicate results.
        /// </param>
        /// <param name="input">
        /// Records to process and records or entities to exclude from the answer.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="effort">
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="previousRunId">
        /// Completed run ID to continue from. Must belong to the same team.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="metadata">
        /// Caller-provided metadata stored with the run.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
        /// <param name="dataSources">
        /// Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AgentRun> CreateAgentRunAsync(
            string query,
            global::Exa.CreateAgentRunAccept? accept = default,
            string? exaBeta = default,
            string? systemPrompt = default,
            global::Exa.CreateAgentRunRequestInput? input = default,
            object? outputSchema = default,
            global::Exa.AgentEffort? effort = default,
            string? previousRunId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? dataSources = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}