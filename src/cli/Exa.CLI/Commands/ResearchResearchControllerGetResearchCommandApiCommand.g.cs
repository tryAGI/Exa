#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class ResearchResearchControllerGetResearchCommandApiCommand
{
    private static Argument<string> ResearchId { get; } = new(
        name: @"research-id")
    {
        Description = @"The unique identifier of the research request to retrieve",
    };

    private static Option<string?> Stream { get; } = new(
        name: @"--stream")
    {
        Description = @"Set to ""true"" to receive real-time updates via Server-Sent Events (SSE)",
    };

    private static Option<string?> Events { get; } = new(
        name: @"--events")
    {
        Description = @"Set to ""true"" to include the detailed event log of all operations performed",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.ResearchDtoClass value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.ResearchDtoClass value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"controller-get-research", @"Get a research request by id
Retrieve research by ID. Add ?stream=true for real-time SSE updates.");
                        command.Arguments.Add(ResearchId);
                        command.Options.Add(Stream);
                        command.Options.Add(Events);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var researchId = parseResult.GetRequiredValue(ResearchId);
                        var stream = parseResult.GetValue(Stream);
                        var events = parseResult.GetValue(Events);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Research.ResearchControllerGetResearchAsync(
                                    researchId: researchId,
                                    stream: stream,
                                    events: events,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Exa.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}