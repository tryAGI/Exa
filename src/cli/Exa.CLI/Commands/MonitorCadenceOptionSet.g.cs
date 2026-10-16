#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record MonitorCadenceOptionSet(
    Option<string> Cron,
                     Option<string?> Timezone)
{
    public static MonitorCadenceOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new MonitorCadenceOptionSet(
                        Cron: new Option<string>($"--{normalizedPrefix}cron")
                {
                    Description = @"Cron expression for monitor cadence (must be a valid Unix cron with 5 fields). The schedule must trigger at most once per day.",
                    Required = true,
                },
                Timezone: new Option<string?>($"--{normalizedPrefix}timezone")
                {
                    Description = @"IANA timezone (e.g., ""America/New_York"")",
                }
        );
    }
}