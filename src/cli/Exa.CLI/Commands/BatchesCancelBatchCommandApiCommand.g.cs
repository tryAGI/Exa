#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class BatchesCancelBatchCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Batch ID.",
    };

    private static Option<global::Exa.CancelBatchExaBeta> ExaBeta { get; } = new(
        name: @"--exa-beta")
    {
        Description = @"Required beta token for the Batch API.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.Batch value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.Batch value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"cancel-batch", @"Cancel a batch
Request cancellation of a batch. The batch stops scheduling new requests and drains in-flight work before settling to `cancelled`. Cancelling a batch that is already `cancelling` or `cancelled` is idempotent and returns the batch unchanged. A batch that has already reached a terminal status (`completed` or `expired`) cannot be cancelled and the request fails with a 409.");
                        command.Arguments.Add(Id);
                        command.Options.Add(ExaBeta);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var exaBeta = parseResult.GetRequiredValue(ExaBeta);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Batches.CancelBatchAsync(
                                    id: id,
                                    exaBeta: exaBeta,
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