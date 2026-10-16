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
                    Description = @"Maximum amount this run can spend in US dollars. Accepts $1–$100 and applies only to `auto` and `ultra`; when omitted, the default cap is $5 for `auto` and $20 for `ultra`.",
                },
                MaxDurationSeconds: new Option<int?>($"--{normalizedPrefix}max-duration-seconds")
                {
                    Description = @"Soft wall-clock ceiling for the run in seconds. Accepts 300–10,800 (5 minutes to 3 hours) and applies only to `ultra`. As the run approaches the limit, the agent stops starting new work and returns what it has found with `stopReason: ""time_limit_reached""`.",
                }
        );
    }
}