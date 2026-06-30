#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record CreateAgentRunRequestBudgetOptionSet(
    Option<double?> MaxCostDollars)
{
    public static CreateAgentRunRequestBudgetOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateAgentRunRequestBudgetOptionSet(
                        MaxCostDollars: new Option<double?>($"--{normalizedPrefix}max-cost-dollars")
                {
                    Description = @"Accepted for compatibility and currently ignored.",
                }
        );
    }
}