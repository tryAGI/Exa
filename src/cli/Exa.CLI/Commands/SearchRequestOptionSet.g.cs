#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record SearchRequestOptionSet(
    Option<int?> NumResults,
                     Option<bool?> Moderation,
                     Option<string> Query,
                     Option<string?> Type,
                     Option<string?> Objective,
                     Option<string?> UserIdentifier,
                     Option<string?> SystemPrompt,
                     Option<bool?> Stream)
{
    public static SearchRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SearchRequestOptionSet(
                        NumResults: new Option<int?>($"--{normalizedPrefix}num-results")
                {
                    Description = @"",
                },
                Moderation: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}moderation", description: @""),
                Query: new Option<string>($"--{normalizedPrefix}query")
                {
                    Description = @"The query string for the search.",
                    Required = true,
                },
                Type: new Option<string?>($"--{normalizedPrefix}type")
                {
                    Description = @"The search mode to use. Defaults to `auto`, a balanced mode recommended for most applications.

- `auto`: The default. A balanced mode that optimizes for both quality and speed and is recommended for most applications.
- `lite`: Low-cost, low-latency search for real-time and interactive experiences such as chat, voice agents, and autocomplete. Accepts only `query` (a single string), `objective`, `userIdentifier`, `metadata`, `category`, `numResults`, `contents.highlights`, `contents.text`, `contents.snapshotAsOf`, `userLocation`, `includeDomains`, `excludeDomains`, `startPublishedDate`, `endPublishedDate`, `moderation`, and `compliance`; a request that sets any other parameter is rejected. Serves cached content only; it never fetches live, so the freshness options are rejected.
- `deep-lite`: Performs lightweight research with synthesized results and a consistent 4-second latency, lower than full deep search.
- `deep`: Conducts comprehensive multi-step research with synthesis.
- `instant`: Legacy. Use `lite` instead. Runs a minimum-latency search that trades some search depth for speed. Unlike `lite`, it accepts every search parameter.
- `fast`: Legacy. Use `lite` instead. Runs a reduced-latency search for user-facing and interactive workflows. Unlike `lite`, it accepts every search parameter.
- `deep-reasoning`: Legacy. Use `deep` instead. Runs `deep` with stronger reasoning at each step, for complex analysis and decision-making tasks. For agentic, multi-step research, use the Agent API.",
                },
                Objective: new Option<string?>($"--{normalizedPrefix}objective")
                {
                    Description = @"The broader goal this search serves: the task the caller is working on, beyond the query itself. When exposing this field to an agent as a tool parameter, describe it as: ""Goal for this search turn; say which documents should rank first, which should be excluded, and what specific facts or figures to pull from them.""",
                },
                UserIdentifier: new Option<string?>($"--{normalizedPrefix}user-identifier")
                {
                    Description = @"An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.",
                },
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"")
        );
    }
}