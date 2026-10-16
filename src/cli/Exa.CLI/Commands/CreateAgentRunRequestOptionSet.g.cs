#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record CreateAgentRunRequestOptionSet(
    Option<string> Query,
                     Option<string?> SystemPrompt,
                     Option<global::Exa.AgentEffort?> Effort,
                     Option<string?> PreviousRunId,
                     Option<string?> UserIdentifier)
{
    public static CreateAgentRunRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateAgentRunRequestOptionSet(
                        Query: new Option<string>($"--{normalizedPrefix}query")
                {
                    Description = @"Natural-language question or instructions for the request.",
                    Required = true,
                },
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.",
                },
                Effort: new Option<global::Exa.AgentEffort?>($"--{normalizedPrefix}effort")
                {
                    Description = @"Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort. `ultra` is the highest-effort tier for work where completeness and thoroughness matter more than latency or cost, including large list building, deep multi-source research, and criteria that are hard to verify.",
                },
                PreviousRunId: new Option<string?>($"--{normalizedPrefix}previous-run-id")
                {
                    Description = @"Completed run ID to continue from. Must belong to the same team.",
                },
                UserIdentifier: new Option<string?>($"--{normalizedPrefix}user-identifier")
                {
                    Description = @"An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.",
                }
        );
    }
}