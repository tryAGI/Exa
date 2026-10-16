#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebsetsPreviewWebsetsPreviewCommandApiCommand
{
    private static Option<bool?> Search { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--search",
        description: @"Whether you want to search for a preview list of items or not");

    private static Option<global::Exa.PreviewWebsetParametersSearch> RequestSearch { get; } = new(
        name: @"--search")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.PreviewWebsetResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.PreviewWebsetResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"websets-preview", @"Preview a webset
Returns how a search query will be interpreted before you create a Webset, including the detected entity, generated criteria, and suggested enrichments.");
                        command.Options.Add(Search);
                        command.Options.Add(RequestSearch);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var search = parseResult.GetValue(Search);
                        var requestSearch = parseResult.GetRequiredValue(RequestSearch);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebsetsPreview.WebsetsPreviewAsync(
                                    search: search,
                                    requestSearch: requestSearch,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Exa.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}