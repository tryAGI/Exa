#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebsetsWebsetsCreateCommandApiCommand
{
    private static Option<string?> Title { get; } = new(
        name: @"--title")
    {
        Description = @"Optional name that appears anywhere the Webset is displayed. Leave empty to have Exa generate one automatically.",
    };

    private static Option<global::Exa.CreateWebsetParametersSearch?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Create initial search for the Webset.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>?> Import { get; } = new(
        name: @"--import")
    {
        Description = @"Import data from existing Websets and Imports into this Webset.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>?> Enrichments { get; } = new(
        name: @"--enrichments")
    {
        Description = @"Add enrichments to extract additional data from found items.

Enrichments automatically search for and extract specific information (like contact details, funding data, employee counts, etc.) from each item added to your Webset.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>?> Exclude { get; } = new(
        name: @"--exclude")
    {
        Description = @"Global exclusion sources (existing imports or websets) that apply to all operations within this Webset. Any results found within these sources will be omitted across all search and import operations.",
    };

    private static Option<string?> ExternalId { get; } = new(
        name: @"--external-id")
    {
        Description = @"The external identifier for the webset.

You can use this to reference the Webset by your own internal identifiers.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.Webset value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.Webset value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create", @"Create a Webset
Creates a new Webset with optional search, import, and enrichment configurations. The Webset will automatically begin processing once created.

You can specify an `externalId` to reference the Webset with your own identifiers for easier integration.");
                        command.Options.Add(Title);
                        command.Options.Add(Search);
                        command.Options.Add(Import);
                        command.Options.Add(Enrichments);
                        command.Options.Add(Exclude);
                        command.Options.Add(ExternalId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.CreateWebsetParameters>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var title = CliRuntime.WasSpecified(parseResult, Title) ? parseResult.GetValue(Title) : (__requestBase is { } __TitleBaseValue ? __TitleBaseValue.Title : default);
                        var search = CliRuntime.WasSpecified(parseResult, Search) ? parseResult.GetValue(Search) : (__requestBase is { } __SearchBaseValue ? __SearchBaseValue.Search : default);
                        var import = CliRuntime.WasSpecified(parseResult, Import) ? parseResult.GetValue(Import) : (__requestBase is { } __ImportBaseValue ? __ImportBaseValue.Import : default);
                        var enrichments = CliRuntime.WasSpecified(parseResult, Enrichments) ? parseResult.GetValue(Enrichments) : (__requestBase is { } __EnrichmentsBaseValue ? __EnrichmentsBaseValue.Enrichments : default);
                        var exclude = CliRuntime.WasSpecified(parseResult, Exclude) ? parseResult.GetValue(Exclude) : (__requestBase is { } __ExcludeBaseValue ? __ExcludeBaseValue.Exclude : default);
                        var externalId = CliRuntime.WasSpecified(parseResult, ExternalId) ? parseResult.GetValue(ExternalId) : (__requestBase is { } __ExternalIdBaseValue ? __ExternalIdBaseValue.ExternalId : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Websets.WebsetsCreateAsync(
                                    title: title,
                                    search: search,
                                    import: import,
                                    enrichments: enrichments,
                                    exclude: exclude,
                                    externalId: externalId,
                                    metadata: metadata,
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