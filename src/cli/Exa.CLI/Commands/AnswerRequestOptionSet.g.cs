#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record AnswerRequestOptionSet(
    Option<string> Query,
                     Option<bool?> Stream,
                     Option<bool?> Text,
                     Option<global::Exa.AnswerRequestModel?> Model,
                     Option<string?> SystemPrompt,
                     Option<string?> UserIdentifier)
{
    public static AnswerRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AnswerRequestOptionSet(
                        Query: new Option<string>($"--{normalizedPrefix}query")
                {
                    Description = @"Natural-language question or instructions for the request.",
                    Required = true,
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"If true, the response is returned as a server-sent events (SSE) stream."),
                Text: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}text", description: @"If true, returns full page text with default settings. If false, disables text return."),
                Model: new Option<global::Exa.AnswerRequestModel?>($"--{normalizedPrefix}model")
                {
                    Description = @"The model used to generate the answer.",
                },
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.",
                },
                UserIdentifier: new Option<string?>($"--{normalizedPrefix}user-identifier")
                {
                    Description = @"An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.",
                }
        );
    }
}