#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class BatchesListBatchesCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Pagination cursor from a previous response",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of batches to return per page. Defaults to 100 when omitted; there is no upper bound.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Return only completed batches, ordered by expiry. Send it on every page request when paginating.",
    };

    private static Option<global::Exa.ListBatchesExaBeta> ExaBeta { get; } = new(
        name: @"--exa-beta")
    {
        Description = @"Required beta token for the Batch API.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.BatchList value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.BatchList value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"list-batches", @"List batches
List batches for your team, ordered from newest to oldest.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Status);
                        command.Options.Add(ExaBeta);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var status = parseResult.GetValue(Status);
                        var exaBeta = parseResult.GetRequiredValue(ExaBeta);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Batches.ListBatchesAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    status: status,
                                    exaBeta: exaBeta,
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
        CustomizeCommand(ref command);
        return command;
    }
}