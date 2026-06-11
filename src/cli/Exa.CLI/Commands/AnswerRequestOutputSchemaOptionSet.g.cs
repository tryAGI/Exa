#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal sealed record AnswerRequestOutputSchemaOptionSet(
    Option<string?> Type,
                     Option<global::System.Collections.Generic.IList<string>?> Required,
                     Option<string?> DescriptionOption,
                     Option<bool?> AdditionalProperties)
{
    public static AnswerRequestOutputSchemaOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AnswerRequestOutputSchemaOptionSet(
                        Type: new Option<string?>($"--{normalizedPrefix}type")
                {
                    Description = @"The root schema type (typically ""object"").",
                },
                Required: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}required")
                {
                    Description = @"List of required property names.",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"A description of the schema.",
                },
                AdditionalProperties: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}additional-properties", description: @"Whether to allow properties not listed in `properties`.")
        );
    }
}