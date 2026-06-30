#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record CreateAgentRunRequestOptionSet(
    Option<string> Query,
                     Option<string?> SystemPrompt,
                     Option<global::Exa.AgentEffort?> Effort,
                     Option<string?> PreviousRunId)
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
                    Description = @"Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort.",
                },
                PreviousRunId: new Option<string?>($"--{normalizedPrefix}previous-run-id")
                {
                    Description = @"Completed run ID to continue from. Must belong to the same team.",
                }
        );
    }
}