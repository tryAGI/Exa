#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record MonitorBehaviorOptionSet(
    Option<string> Type)
{
    public static MonitorBehaviorOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new MonitorBehaviorOptionSet(
                        Type: new Option<string>($"--{normalizedPrefix}type")
                {
                    Description = @"Configure the Monitor to find new Items matching your search criteria",
                    DefaultValueFactory = _ => "search",
                }
        );
    }
}