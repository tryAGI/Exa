#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class AgentListAgentRunEventsAsStreamCommandApiCommand
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

    public static Command Create()
    {
        var command = new Command(@"list-agent-run-events-as-stream", @"List run events
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


                                var response = client.Agent.ListAgentRunEventsAsStreamAsync(
                                    id: id,
                                    limit: limit,
                                    cursor: cursor,
                                    accept: accept,
                                    lastEventId: lastEventId,
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::Exa.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}