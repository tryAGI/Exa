#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record AgentBudgetOptionSet(
    Option<double?> MaxCostDollars,
                     Option<int?> MaxDurationSeconds)
{
    public static AgentBudgetOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentBudgetOptionSet(
                        MaxCostDollars: new Option<double?>($"--{normalizedPrefix}max-cost-dollars")
                {
                    Description = @"Accepts $1 to $100. For `auto` and `ultra`, caps total run cost with default caps of $5 and $20 respectively. For fixed efforts, caps contact-enrichment calls using the budget remaining after the fixed request price, without limiting research or reasoning steps. Fixed efforts have no default cap, and an explicit cap must cover the fixed request price.",
                },
                MaxDurationSeconds: new Option<int?>($"--{normalizedPrefix}max-duration-seconds")
                {
                    Description = @"Soft wall-clock ceiling for the run in seconds. Accepts 300–10,800 (5 minutes to 3 hours) and applies only to `ultra`. As the run approaches the limit, the agent stops starting new work and returns what it has found with `stopReason: ""time_limit_reached""`.",
                }
        );
    }
}