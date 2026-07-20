#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record AnswerRequestOptionSet(
    Option<string> Query,
                     Option<bool?> Stream,
                     Option<bool?> Text)
{
    public static AnswerRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AnswerRequestOptionSet(
                        Query: new Option<string>($"--{normalizedPrefix}query")
                {
                    Description = @"The question or query to answer.",
                    Required = true,
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"If true, the response is returned as a server-sent events (SSS) stream."),
                Text: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}text", description: @"If true, the response includes full text content in the search results")
        );
    }
}