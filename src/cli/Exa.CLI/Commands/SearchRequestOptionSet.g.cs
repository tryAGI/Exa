#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record SearchRequestOptionSet(
    Option<int?> NumResults,
                     Option<bool?> Moderation,
                     Option<string> Query,
                     Option<string?> UserLocation,
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
                UserLocation: new Option<string?>($"--{normalizedPrefix}user-location")
                {
                    Description = @"",
                },
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"")
        );
    }
}