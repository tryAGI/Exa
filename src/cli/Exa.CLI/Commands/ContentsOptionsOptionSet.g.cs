#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record ContentsOptionsOptionSet(
    Option<int?> LivecrawlTimeout,
                     Option<int?> MaxAgeHours,
                     Option<string?> CrawledBeforeDate,
                     Option<int?> Subpages)
{
    public static ContentsOptionsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ContentsOptionsOptionSet(
                        LivecrawlTimeout: new Option<int?>($"--{normalizedPrefix}livecrawl-timeout")
                {
                    Description = @"",
                },
                MaxAgeHours: new Option<int?>($"--{normalizedPrefix}max-age-hours")
                {
                    Description = @"",
                },
                CrawledBeforeDate: new Option<string?>($"--{normalizedPrefix}crawled-before-date")
                {
                    Description = @"Deprecated. Use `snapshotAsOf` instead. Alias of snapshotAsOf with identical behavior.",
                },
                Subpages: new Option<int?>($"--{normalizedPrefix}subpages")
                {
                    Description = @"",
                }
        );
    }
}