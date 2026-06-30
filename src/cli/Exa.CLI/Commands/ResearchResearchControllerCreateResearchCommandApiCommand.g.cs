#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class ResearchResearchControllerCreateResearchCommandApiCommand
{
    private static Option<global::Exa.ResearchCreateRequestDtoClassModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Research model to use. exa-research is faster and cheaper, while exa-research-pro provides more thorough analysis and stronger reasoning.",
    };

    private static Option<string> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"Instructions for what you would like research on. A good prompt clearly defines what information you want to find, how research should be conducted, and what the output should look like.",
        Required = true,
    };

    private static Option<object?> OutputSchema { get; } = new(
        name: @"--output-schema")
    {
        Description = @"JSON Schema to enforce structured output. When provided, the research output will be validated against this schema and returned as parsed JSON.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
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
        var command = new Command(@"controller-create-research", @"Create a new research request");
                        command.Options.Add(Model);
                        command.Options.Add(Instructions);
                        command.Options.Add(OutputSchema);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.ResearchCreateRequestDtoClass>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var instructions = parseResult.GetRequiredValue(Instructions);
                        var outputSchema = CliRuntime.WasSpecified(parseResult, OutputSchema) ? parseResult.GetValue(OutputSchema) : (__requestBase is { } __OutputSchemaBaseValue ? __OutputSchemaBaseValue.OutputSchema : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Research.ResearchControllerCreateResearchAsync(
                                    model: model,
                                    instructions: instructions,
                                    outputSchema: outputSchema,
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