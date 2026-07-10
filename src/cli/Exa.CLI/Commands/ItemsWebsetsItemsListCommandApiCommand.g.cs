#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class ItemsWebsetsItemsListCommandApiCommand
{
    private static Argument<string> Webset { get; } = new(
        name: @"webset")
    {
        Description = @"The id or externalId of the Webset",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"The cursor to paginate through the results",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The number of results to return",
    };

    private static Option<string?> SourceId { get; } = new(
        name: @"--source-id")
    {
        Description = @"The id of the source",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.ListWebsetItemResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.ListWebsetItemResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"websets-items-list", @"List all Items for a Webset
Returns a list of Webset Items.

You can paginate through the Items using the `cursor` parameter.");
                        command.Arguments.Add(Webset);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(SourceId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var webset = parseResult.GetRequiredValue(Webset);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var sourceId = parseResult.GetValue(SourceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Items.WebsetsItemsListAsync(
                                    webset: webset,
                                    cursor: cursor,
                                    limit: limit,
                                    sourceId: sourceId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Exa.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Exa.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}