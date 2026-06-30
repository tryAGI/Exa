#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class EnrichmentsWebsetsEnrichmentsUpdateCommandApiCommand
{
    private static Argument<string> Webset { get; } = new(
        name: @"webset")
    {
        Description = @"",
    };

    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Provide a description of the enrichment task you want to perform to each Webset Item.",
    };

    private static Option<global::Exa.UpdateEnrichmentParametersFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Format of the enrichment response.

We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>?> OptionsOption { get; } = new(
        name: @"--options")
    {
        Description = @"When the format is options, the different options for the enrichment agent to choose from.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Set of key-value pairs you want to associate with this object.",
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

    public static Command Create()
    {
        var command = new Command(@"websets-enrichments-update", @"Update an Enrichment
Update an Enrichment configuration for a Webset.");
                        command.Arguments.Add(Webset);
                        command.Arguments.Add(Id);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Format);
                        command.Options.Add(OptionsOption);
                        command.Options.Add(Metadata);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.UpdateEnrichmentParameters>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var webset = parseResult.GetRequiredValue(Webset);
                        var id = parseResult.GetRequiredValue(Id);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var options = CliRuntime.WasSpecified(parseResult, OptionsOption) ? parseResult.GetValue(OptionsOption) : (__requestBase is { } __OptionsBaseValue ? __OptionsBaseValue.Options : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Enrichments.WebsetsEnrichmentsUpdateAsync(
                                    webset: webset,
                                    id: id,
                                    description: description,
                                    format: format,
                                    options: options,
                                    metadata: metadata,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}