#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class SearchCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> IncludeDomains { get; } = new(
        name: @"--include-domains")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ExcludeDomains { get; } = new(
        name: @"--exclude-domains")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> StartCrawlDate { get; } = new(
        name: @"--start-crawl-date")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> EndCrawlDate { get; } = new(
        name: @"--end-crawl-date")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> StartPublishedDate { get; } = new(
        name: @"--start-published-date")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> EndPublishedDate { get; } = new(
        name: @"--end-published-date")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>?> Context { get; } = new(
        name: @"--context")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AdditionalQueries { get; } = new(
        name: @"--additional-queries")
    {
        Description = @"",
    };

    private static Option<global::Exa.SearchRequestType2?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"",
    };

    private static Option<global::Exa.SearchRequestCategory2?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"",
    };

    private static Option<global::Exa.SearchRequestCompliance2?> Compliance { get; } = new(
        name: @"--compliance")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>?> OutputSchema { get; } = new(
        name: @"--output-schema")
    {
        Description = @"",
    };
    private static readonly SearchRequestOptionSet SearchRequestOptionSetOptions = SearchRequestOptionSet.Create();

    private static readonly ContentsOptionsOptionSet ContentsOptions = ContentsOptionsOptionSet.Create(@"contents");
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.SearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.SearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"search", @"Search
Perform a search with an Exa prompt-engineered query and retrieve a list of relevant results. Optionally get contents.");
                        command.Options.Add(IncludeDomains);
                        command.Options.Add(ExcludeDomains);
                        command.Options.Add(StartCrawlDate);
                        command.Options.Add(EndCrawlDate);
                        command.Options.Add(StartPublishedDate);
                        command.Options.Add(EndPublishedDate);
                        command.Options.Add(Context);
                        command.Options.Add(AdditionalQueries);
                        command.Options.Add(Type);
                        command.Options.Add(Category);
                        command.Options.Add(Compliance);
                        command.Options.Add(OutputSchema);                        command.Options.Add(SearchRequestOptionSetOptions.NumResults);
                        command.Options.Add(SearchRequestOptionSetOptions.Moderation);
                        command.Options.Add(SearchRequestOptionSetOptions.Query);
                        command.Options.Add(SearchRequestOptionSetOptions.UserLocation);
                        command.Options.Add(SearchRequestOptionSetOptions.SystemPrompt);                        command.Options.Add(ContentsOptions.LivecrawlTimeout);
                        command.Options.Add(ContentsOptions.MaxAgeHours);
                        command.Options.Add(ContentsOptions.Subpages);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.SearchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var includeDomains = CliRuntime.WasSpecified(parseResult, IncludeDomains) ? parseResult.GetValue(IncludeDomains) : (__requestBase is { } __IncludeDomainsBaseValue ? __IncludeDomainsBaseValue.IncludeDomains : default);
                        var excludeDomains = CliRuntime.WasSpecified(parseResult, ExcludeDomains) ? parseResult.GetValue(ExcludeDomains) : (__requestBase is { } __ExcludeDomainsBaseValue ? __ExcludeDomainsBaseValue.ExcludeDomains : default);
                        var startCrawlDate = CliRuntime.WasSpecified(parseResult, StartCrawlDate) ? parseResult.GetValue(StartCrawlDate) : (__requestBase is { } __StartCrawlDateBaseValue ? __StartCrawlDateBaseValue.StartCrawlDate : default);
                        var endCrawlDate = CliRuntime.WasSpecified(parseResult, EndCrawlDate) ? parseResult.GetValue(EndCrawlDate) : (__requestBase is { } __EndCrawlDateBaseValue ? __EndCrawlDateBaseValue.EndCrawlDate : default);
                        var startPublishedDate = CliRuntime.WasSpecified(parseResult, StartPublishedDate) ? parseResult.GetValue(StartPublishedDate) : (__requestBase is { } __StartPublishedDateBaseValue ? __StartPublishedDateBaseValue.StartPublishedDate : default);
                        var endPublishedDate = CliRuntime.WasSpecified(parseResult, EndPublishedDate) ? parseResult.GetValue(EndPublishedDate) : (__requestBase is { } __EndPublishedDateBaseValue ? __EndPublishedDateBaseValue.EndPublishedDate : default);
                        var context = CliRuntime.WasSpecified(parseResult, Context) ? parseResult.GetValue(Context) : (__requestBase is { } __ContextBaseValue ? __ContextBaseValue.Context : default);
                        var additionalQueries = CliRuntime.WasSpecified(parseResult, AdditionalQueries) ? parseResult.GetValue(AdditionalQueries) : (__requestBase is { } __AdditionalQueriesBaseValue ? __AdditionalQueriesBaseValue.AdditionalQueries : default);
                        var type = CliRuntime.WasSpecified(parseResult, Type) ? parseResult.GetValue(Type) : (__requestBase is { } __TypeBaseValue ? __TypeBaseValue.Type : default);
                        var category = CliRuntime.WasSpecified(parseResult, Category) ? parseResult.GetValue(Category) : (__requestBase is { } __CategoryBaseValue ? __CategoryBaseValue.Category : default);
                        var compliance = CliRuntime.WasSpecified(parseResult, Compliance) ? parseResult.GetValue(Compliance) : (__requestBase is { } __ComplianceBaseValue ? __ComplianceBaseValue.Compliance : default);
                        var outputSchema = CliRuntime.WasSpecified(parseResult, OutputSchema) ? parseResult.GetValue(OutputSchema) : (__requestBase is { } __OutputSchemaBaseValue ? __OutputSchemaBaseValue.OutputSchema : default);                        var numResults = CliRuntime.WasSpecified(parseResult, SearchRequestOptionSetOptions.NumResults) ? parseResult.GetValue(SearchRequestOptionSetOptions.NumResults) : (__requestBase is { } __NumResultsBaseValue ? __NumResultsBaseValue.NumResults : default);
                        var moderation = CliRuntime.WasSpecified(parseResult, SearchRequestOptionSetOptions.Moderation) ? parseResult.GetValue(SearchRequestOptionSetOptions.Moderation) : (__requestBase is { } __ModerationBaseValue ? __ModerationBaseValue.Moderation : default);
                        var query = parseResult.GetRequiredValue(SearchRequestOptionSetOptions.Query);
                        var userLocation = CliRuntime.WasSpecified(parseResult, SearchRequestOptionSetOptions.UserLocation) ? parseResult.GetValue(SearchRequestOptionSetOptions.UserLocation) : (__requestBase is { } __UserLocationBaseValue ? __UserLocationBaseValue.UserLocation : default);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, SearchRequestOptionSetOptions.SystemPrompt) ? parseResult.GetValue(SearchRequestOptionSetOptions.SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);

                        var __ContentsBase = __requestBase is { } __ContentsBaseValue ? __ContentsBaseValue.Contents : default;                        var contentsLivecrawlTimeout = CliRuntime.WasSpecified(parseResult, ContentsOptions.LivecrawlTimeout) ? parseResult.GetValue(ContentsOptions.LivecrawlTimeout) : (__ContentsBase is { } __ContentslivecrawlTimeoutBaseValue ? __ContentslivecrawlTimeoutBaseValue.LivecrawlTimeout : default);
                        var contentsMaxAgeHours = CliRuntime.WasSpecified(parseResult, ContentsOptions.MaxAgeHours) ? parseResult.GetValue(ContentsOptions.MaxAgeHours) : (__ContentsBase is { } __ContentsmaxAgeHoursBaseValue ? __ContentsmaxAgeHoursBaseValue.MaxAgeHours : default);
                        var contentsSubpages = CliRuntime.WasSpecified(parseResult, ContentsOptions.Subpages) ? parseResult.GetValue(ContentsOptions.Subpages) : (__ContentsBase is { } __ContentssubpagesBaseValue ? __ContentssubpagesBaseValue.Subpages : default);
                        var __ContentsSpecified = CliRuntime.WasSpecified(parseResult, ContentsOptions.LivecrawlTimeout) || CliRuntime.WasSpecified(parseResult, ContentsOptions.MaxAgeHours) || CliRuntime.WasSpecified(parseResult, ContentsOptions.Subpages);
                        var contents =
                            __ContentsSpecified || __ContentsBase is not null
                                ? new global::Exa.ContentsOptions
                                {
	                                LivecrawlTimeout = contentsLivecrawlTimeout,
                                MaxAgeHours = contentsMaxAgeHours,
                                Subpages = contentsSubpages,

                                }
                                : __ContentsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SearchAsync(
                                    includeDomains: includeDomains,
                                    excludeDomains: excludeDomains,
                                    startCrawlDate: startCrawlDate,
                                    endCrawlDate: endCrawlDate,
                                    startPublishedDate: startPublishedDate,
                                    endPublishedDate: endPublishedDate,
                                    context: context,
                                    additionalQueries: additionalQueries,
                                    type: type,
                                    category: category,
                                    compliance: compliance,
                                    outputSchema: outputSchema,
                                    numResults: numResults,
                                    moderation: moderation,
                                    query: query,
                                    userLocation: userLocation,
                                    systemPrompt: systemPrompt,
                                    contents: contents,
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