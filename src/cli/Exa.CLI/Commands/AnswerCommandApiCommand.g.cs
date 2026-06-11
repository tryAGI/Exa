#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class AnswerCommandApiCommand
{
    private static readonly AnswerRequestOptionSet AnswerRequestOptionSetOptions = AnswerRequestOptionSet.Create();

    private static readonly AnswerRequestOutputSchemaOptionSet OutputSchemaOptions = AnswerRequestOutputSchemaOptionSet.Create(@"output-schema");
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.AllOf<global::Exa.AnswerResult, global::Exa.AnswerResponse2> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.AllOf<global::Exa.AnswerResult, global::Exa.AnswerResponse2> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"answer", @"Generate an answer from search results
Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.
");
                        command.Options.Add(AnswerRequestOptionSetOptions.Query);
                        command.Options.Add(AnswerRequestOptionSetOptions.Text);                        command.Options.Add(OutputSchemaOptions.Type);
                        command.Options.Add(OutputSchemaOptions.Required);
                        command.Options.Add(OutputSchemaOptions.DescriptionOption);
                        command.Options.Add(OutputSchemaOptions.AdditionalProperties);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.AnswerRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);                        var query = parseResult.GetRequiredValue(AnswerRequestOptionSetOptions.Query);
                        var text = CliRuntime.WasSpecified(parseResult, AnswerRequestOptionSetOptions.Text) ? parseResult.GetValue(AnswerRequestOptionSetOptions.Text) : __requestBase is not null ? __requestBase.Text : default;

                        var __outputSchemaBase = __requestBase?.OutputSchema;                        var outputSchemaType = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Type) ? parseResult.GetValue(OutputSchemaOptions.Type) : __outputSchemaBase is not null ? __outputSchemaBase.Type : default;
                        var outputSchemaRequired = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Required) ? parseResult.GetValue(OutputSchemaOptions.Required) : __outputSchemaBase is not null ? __outputSchemaBase.Required : default;
                        var outputSchemaDescriptionOption = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.DescriptionOption) ? parseResult.GetValue(OutputSchemaOptions.DescriptionOption) : __outputSchemaBase is not null ? __outputSchemaBase.Description : default;
                        var outputSchemaAdditionalProperties = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.AdditionalProperties) ? parseResult.GetValue(OutputSchemaOptions.AdditionalProperties) : __outputSchemaBase is not null ? __outputSchemaBase.AdditionalProperties : default;
                        var __outputSchemaSpecified = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Type) || CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Required) || CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.DescriptionOption) || CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.AdditionalProperties);
                        var outputSchema =
                            __outputSchemaSpecified || __outputSchemaBase is not null
                                ? new global::Exa.AnswerRequestOutputSchema
                                {
	                                Type = outputSchemaType,
                                Required = outputSchemaRequired,
                                Description = outputSchemaDescriptionOption,
                                AdditionalProperties = outputSchemaAdditionalProperties,

                                }
                                : __outputSchemaBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AnswerAsync(
                                    query: query,
                                    text: text,
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