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

- `instant`: Optimized for minimum response time, trading some search depth for speed in real-time experiences such as chat, voice agents, and autocomplete.
- `fast`: Returns high-quality results with reduced latency, making it a good fit for user-facing search and interactive workflows.
- `auto`: The default. A balanced mode that optimizes for both quality and speed and is recommended for most applications.
- `deep-lite`: Performs lightweight research with synthesized results and a consistent 4-second latency, lower than full deep search.
- `deep`: Conducts comprehensive multi-step research with synthesis.
- `deep-reasoning`: Adds stronger reasoning to `deep` for complex analysis and decision-making tasks.",
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