#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebhooksAttemptsWebhooksAttemptsListCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"The ID of the webhook",
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

    private static Option<global::Exa.WebhooksAttemptsListEventType?> EventType { get; } = new(
        name: @"--event-type")
    {
        Description = @"The type of event to filter by",
    };

    private static Option<bool?> Successful { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--successful",
        description: @"Filter attempts by their success status");

                    private static string FormatResponse(ParseResult parseResult, global::Exa.ListWebhookAttemptsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.ListWebhookAttemptsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list", @"List webhook attempts
List all attempts made by a Webhook ordered in descending order.");
                        command.Arguments.Add(Id);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(EventType);
                        command.Options.Add(Successful);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var eventType = parseResult.GetValue(EventType);
                        var successful = parseResult.GetValue(Successful);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhooksAttempts.WebhooksAttemptsListAsync(
                                    id: id,
                                    cursor: cursor,
                                    limit: limit,
                                    eventType: eventType,
                                    successful: successful,
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