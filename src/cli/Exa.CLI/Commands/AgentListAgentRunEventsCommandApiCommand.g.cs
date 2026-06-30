#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class AgentListAgentRunEventsCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Agent run ID.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of results per page",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor for pagination. Use the `nextCursor` value from the previous event list response.",
    };

    private static Option<global::Exa.ListAgentRunEventsAccept?> Accept { get; } = new(
        name: @"--accept")
    {
        Description = @"Set to `text/event-stream` to receive server-sent events.",
    };

    private static Option<string?> LastEventId { get; } = new(
        name: @"--last-event-id")
    {
        Description = @"For SSE replay, return only events after this event ID.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.AgentRunEventList value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.AgentRunEventList value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-agent-run-events", @"List run events
List stored events for an Agent run. Set `Accept: text/event-stream` to replay stored events as server-sent events. Use `cursor` for JSON pagination or `Last-Event-ID` for SSE replay.");
                        command.Arguments.Add(Id);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);
                        command.Options.Add(Accept);
                        command.Options.Add(LastEventId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                        var accept = parseResult.GetValue(Accept);
                        var lastEventId = parseResult.GetValue(LastEventId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agent.ListAgentRunEventsAsync(
                                    id: id,
                                    limit: limit,
                                    cursor: cursor,
                                    accept: accept,
                                    lastEventId: lastEventId,
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