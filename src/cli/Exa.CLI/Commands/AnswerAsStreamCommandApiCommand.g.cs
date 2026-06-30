#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class AnswerAsStreamCommandApiCommand
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

    public static Command Create()
    {
        var command = new Command(@"answer-as-stream", @"Answer
Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.");
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
                        var text = CliRuntime.WasSpecified(parseResult, AnswerRequestOptionSetOptions.Text) ? parseResult.GetValue(AnswerRequestOptionSetOptions.Text) : (__requestBase is { } __TextBaseValue ? __TextBaseValue.Text : default);

                        var __OutputSchemaBase = __requestBase is { } __OutputSchemaBaseValue ? __OutputSchemaBaseValue.OutputSchema : default;                        var outputSchemaType = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Type) ? parseResult.GetValue(OutputSchemaOptions.Type) : (__OutputSchemaBase is { } __OutputSchematypeBaseValue ? __OutputSchematypeBaseValue.Type : default);
                        var outputSchemaRequired = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Required) ? parseResult.GetValue(OutputSchemaOptions.Required) : (__OutputSchemaBase is { } __OutputSchemarequiredBaseValue ? __OutputSchemarequiredBaseValue.Required : default);
                        var outputSchemaDescriptionOption = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.DescriptionOption) ? parseResult.GetValue(OutputSchemaOptions.DescriptionOption) : (__OutputSchemaBase is { } __OutputSchemadescriptionBaseValue ? __OutputSchemadescriptionBaseValue.Description : default);
                        var outputSchemaAdditionalProperties = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.AdditionalProperties) ? parseResult.GetValue(OutputSchemaOptions.AdditionalProperties) : (__OutputSchemaBase is { } __OutputSchemaadditionalPropertiesBaseValue ? __OutputSchemaadditionalPropertiesBaseValue.AdditionalProperties : default);
                        var __OutputSchemaSpecified = CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Type) || CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.Required) || CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.DescriptionOption) || CliRuntime.WasSpecified(parseResult, OutputSchemaOptions.AdditionalProperties);
                        var outputSchema =
                            __OutputSchemaSpecified || __OutputSchemaBase is not null
                                ? new global::Exa.AnswerRequestOutputSchema
                                {
	                                Type = outputSchemaType,
                                Required = outputSchemaRequired,
                                Description = outputSchemaDescriptionOption,
                                AdditionalProperties = outputSchemaAdditionalProperties,

                                }
                                : __OutputSchemaBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.AnswerAsStreamAsync(
                                    query: query,
                                    text: text,
                                    outputSchema: outputSchema,
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