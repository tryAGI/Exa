#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class SearchCommandApiCommand
{
    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"The query string for the search.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AdditionalQueries { get; } = new(
        name: @"--additional-queries")
    {
        Description = @"Additional query variations for deep search. Only works with type=""deep"" or type=""deep-reasoning"". When provided, these queries are used alongside the main query for comprehensive results.",
    };

    private static Option<global::Exa.SearchRequestType?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines neural and other search methods, fast uses streamlined versions of the search models, deep is light deep search, deep-reasoning is base deep search, and instant provides the lowest latency search optimized for real-time applications.",
    };

    private static Option<global::Exa.SearchRequestCategory?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"A data category to focus on. The `people` and `company` categories have improved quality for finding LinkedIn profiles and company pages. Note: The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `includeText`, `excludeText`, `excludeDomains`. For `people` category, `includeDomains` only accepts LinkedIn domains. Using unsupported parameters will result in a 400 error.",
    };

    private static Option<string?> UserLocation { get; } = new(
        name: @"--user-location")
    {
        Description = @"The two-letter ISO country code of the user, e.g. US.",
    };

    private static Option<int?> NumResults { get; } = new(
        name: @"--num-results")
    {
        Description = @"Number of results to return (up to thousands of results available for custom plans)",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> IncludeDomains { get; } = new(
        name: @"--include-domains")
    {
        Description = @"List of domains to include in the search. If specified, results will only come from these domains.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ExcludeDomains { get; } = new(
        name: @"--exclude-domains")
    {
        Description = @"List of domains to exclude from search results. If specified, no results will be returned from these domains.",
    };

    private static Option<global::System.DateTime?> StartCrawlDate { get; } = new(
        name: @"--start-crawl-date")
    {
        Description = @"Crawl date refers to the date that Exa discovered a link. Results will include links that were crawled after this date. Must be specified in ISO 8601 format.",
    };

    private static Option<global::System.DateTime?> EndCrawlDate { get; } = new(
        name: @"--end-crawl-date")
    {
        Description = @"Crawl date refers to the date that Exa discovered a link. Results will include links that were crawled before this date. Must be specified in ISO 8601 format.",
    };

    private static Option<global::System.DateTime?> StartPublishedDate { get; } = new(
        name: @"--start-published-date")
    {
        Description = @"Only links with a published date after this will be returned. Must be specified in ISO 8601 format.",
    };

    private static Option<global::System.DateTime?> EndPublishedDate { get; } = new(
        name: @"--end-published-date")
    {
        Description = @"Only links with a published date before this will be returned. Must be specified in ISO 8601 format.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> IncludeText { get; } = new(
        name: @"--include-text")
    {
        Description = @"List of strings that must be present in webpage text of results. Currently, only 1 string is supported, of up to 5 words.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ExcludeText { get; } = new(
        name: @"--exclude-text")
    {
        Description = @"List of strings that must not be present in webpage text of results. Currently, only 1 string is supported, of up to 5 words. Checks from the first 1000 words of the webpage text.",
    };

    private static Option<bool?> Moderation { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--moderation",
        description: @"Enable content moderation to filter unsafe content from search results.");

    private static Option<int?> ContentsLivecrawlTimeout { get; } = new(
        name: @"--contents-livecrawl-timeout")
    {
        Description = @"The timeout for livecrawling in milliseconds.",
    };

    private static Option<int?> ContentsMaxAgeHours { get; } = new(
        name: @"--contents-max-age-hours")
    {
        Description = @"Maximum age of cached content in hours. Controls when livecrawling is triggered based on content freshness.
- Positive value (e.g. 24): Use cached content if it's less than this many hours old, otherwise livecrawl.
- 0: Always livecrawl, never use cache.
- -1: Never livecrawl, always use cache.
- Omit (default): Livecrawl as fallback only when no cached content exists.
",
    };

    private static Option<int?> ContentsSubpages { get; } = new(
        name: @"--contents-subpages")
    {
        Description = @"The number of subpages to crawl. The actual number crawled may be limited by system constraints.",
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"search", @"Search
Perform a search with a Exa prompt-engineered query and retrieve a list of relevant results. Optionally get contents.");
                        command.Options.Add(Query);
                        command.Options.Add(AdditionalQueries);
                        command.Options.Add(Type);
                        command.Options.Add(Category);
                        command.Options.Add(UserLocation);
                        command.Options.Add(NumResults);
                        command.Options.Add(IncludeDomains);
                        command.Options.Add(ExcludeDomains);
                        command.Options.Add(StartCrawlDate);
                        command.Options.Add(EndCrawlDate);
                        command.Options.Add(StartPublishedDate);
                        command.Options.Add(EndPublishedDate);
                        command.Options.Add(IncludeText);
                        command.Options.Add(ExcludeText);
                        command.Options.Add(Moderation);
                        command.Options.Add(ContentsLivecrawlTimeout);
                        command.Options.Add(ContentsMaxAgeHours);
                        command.Options.Add(ContentsSubpages);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.AllOf<global::Exa.SearchRequest2, global::Exa.CommonRequest>>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var query = (CliRuntime.WasSpecified(parseResult, Query)
                            ? parseResult.GetValue(Query)
                            : __requestBase.Value1?.Query)
                            ?? throw new CliException(@"Specify query or include it in the base request body.");
                        var additionalQueries = CliRuntime.WasSpecified(parseResult, AdditionalQueries) ? parseResult.GetValue(AdditionalQueries) : (__requestBase is { } __AdditionalQueriesBaseValue ? __AdditionalQueriesBaseValue.Value1?.AdditionalQueries : default);
                        var type = CliRuntime.WasSpecified(parseResult, Type) ? parseResult.GetValue(Type) : (__requestBase is { } __TypeBaseValue ? __TypeBaseValue.Value1?.Type : default);
                        var category = CliRuntime.WasSpecified(parseResult, Category) ? parseResult.GetValue(Category) : (__requestBase is { } __CategoryBaseValue ? __CategoryBaseValue.Value1?.Category : default);
                        var userLocation = CliRuntime.WasSpecified(parseResult, UserLocation) ? parseResult.GetValue(UserLocation) : (__requestBase is { } __UserLocationBaseValue ? __UserLocationBaseValue.Value1?.UserLocation : default);
                        var numResults = CliRuntime.WasSpecified(parseResult, NumResults) ? parseResult.GetValue(NumResults) : (__requestBase is { } __NumResultsBaseValue ? __NumResultsBaseValue.Value2?.NumResults : default);
                        var includeDomains = CliRuntime.WasSpecified(parseResult, IncludeDomains) ? parseResult.GetValue(IncludeDomains) : (__requestBase is { } __IncludeDomainsBaseValue ? __IncludeDomainsBaseValue.Value2?.IncludeDomains : default);
                        var excludeDomains = CliRuntime.WasSpecified(parseResult, ExcludeDomains) ? parseResult.GetValue(ExcludeDomains) : (__requestBase is { } __ExcludeDomainsBaseValue ? __ExcludeDomainsBaseValue.Value2?.ExcludeDomains : default);
                        var startCrawlDate = CliRuntime.WasSpecified(parseResult, StartCrawlDate) ? parseResult.GetValue(StartCrawlDate) : (__requestBase is { } __StartCrawlDateBaseValue ? __StartCrawlDateBaseValue.Value2?.StartCrawlDate : default);
                        var endCrawlDate = CliRuntime.WasSpecified(parseResult, EndCrawlDate) ? parseResult.GetValue(EndCrawlDate) : (__requestBase is { } __EndCrawlDateBaseValue ? __EndCrawlDateBaseValue.Value2?.EndCrawlDate : default);
                        var startPublishedDate = CliRuntime.WasSpecified(parseResult, StartPublishedDate) ? parseResult.GetValue(StartPublishedDate) : (__requestBase is { } __StartPublishedDateBaseValue ? __StartPublishedDateBaseValue.Value2?.StartPublishedDate : default);
                        var endPublishedDate = CliRuntime.WasSpecified(parseResult, EndPublishedDate) ? parseResult.GetValue(EndPublishedDate) : (__requestBase is { } __EndPublishedDateBaseValue ? __EndPublishedDateBaseValue.Value2?.EndPublishedDate : default);
                        var includeText = CliRuntime.WasSpecified(parseResult, IncludeText) ? parseResult.GetValue(IncludeText) : (__requestBase is { } __IncludeTextBaseValue ? __IncludeTextBaseValue.Value2?.IncludeText : default);
                        var excludeText = CliRuntime.WasSpecified(parseResult, ExcludeText) ? parseResult.GetValue(ExcludeText) : (__requestBase is { } __ExcludeTextBaseValue ? __ExcludeTextBaseValue.Value2?.ExcludeText : default);
                        var moderation = CliRuntime.WasSpecified(parseResult, Moderation) ? parseResult.GetValue(Moderation) : (__requestBase is { } __ModerationBaseValue ? __ModerationBaseValue.Value2?.Moderation : default);
                        var contentsLivecrawlTimeout = CliRuntime.WasSpecified(parseResult, ContentsLivecrawlTimeout) ? parseResult.GetValue(ContentsLivecrawlTimeout) : (__requestBase is { } __ContentsLivecrawlTimeoutBaseValue ? __ContentsLivecrawlTimeoutBaseValue.Value2?.Contents?.LivecrawlTimeout : default);
                        var contentsMaxAgeHours = CliRuntime.WasSpecified(parseResult, ContentsMaxAgeHours) ? parseResult.GetValue(ContentsMaxAgeHours) : (__requestBase is { } __ContentsMaxAgeHoursBaseValue ? __ContentsMaxAgeHoursBaseValue.Value2?.Contents?.MaxAgeHours : default);
                        var contentsSubpages = CliRuntime.WasSpecified(parseResult, ContentsSubpages) ? parseResult.GetValue(ContentsSubpages) : (__requestBase is { } __ContentsSubpagesBaseValue ? __ContentsSubpagesBaseValue.Value2?.Contents?.Subpages : default);
                        var __component1 = __requestBase.Value1 ?? new global::Exa.SearchRequest2 { Query = query! };
                        __component1.Query = query;
                        __component1.AdditionalQueries = additionalQueries;
                        __component1.Type = type;
                        __component1.Category = category;
                        __component1.UserLocation = userLocation;

                        var __component2 = __requestBase.Value2 ?? new global::Exa.CommonRequest();
                        __component2.NumResults = numResults;
                        __component2.IncludeDomains = includeDomains;
                        __component2.ExcludeDomains = excludeDomains;
                        __component2.StartCrawlDate = startCrawlDate;
                        __component2.EndCrawlDate = endCrawlDate;
                        __component2.StartPublishedDate = startPublishedDate;
                        __component2.EndPublishedDate = endPublishedDate;
                        __component2.IncludeText = includeText;
                        __component2.ExcludeText = excludeText;
                        __component2.Moderation = moderation;
                        if (CliRuntime.WasSpecified(parseResult, ContentsLivecrawlTimeout) || CliRuntime.WasSpecified(parseResult, ContentsMaxAgeHours) || CliRuntime.WasSpecified(parseResult, ContentsSubpages))
                        {
                            __component2.Contents ??= new global::Exa.ContentsRequest();
                            if (CliRuntime.WasSpecified(parseResult, ContentsLivecrawlTimeout))
                            {
                                __component2.Contents.LivecrawlTimeout = contentsLivecrawlTimeout;
                            }
                            if (CliRuntime.WasSpecified(parseResult, ContentsMaxAgeHours))
                            {
                                __component2.Contents.MaxAgeHours = contentsMaxAgeHours;
                            }
                            if (CliRuntime.WasSpecified(parseResult, ContentsSubpages))
                            {
                                __component2.Contents.Subpages = contentsSubpages;
                            }
                        }
                        if (CliRuntime.WasSpecified(parseResult, NumResults))
                        {
                            __component1.AdditionalProperties?.Remove(@"numResults");
                        }
                        if (CliRuntime.WasSpecified(parseResult, IncludeDomains))
                        {
                            __component1.AdditionalProperties?.Remove(@"includeDomains");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ExcludeDomains))
                        {
                            __component1.AdditionalProperties?.Remove(@"excludeDomains");
                        }
                        if (CliRuntime.WasSpecified(parseResult, StartCrawlDate))
                        {
                            __component1.AdditionalProperties?.Remove(@"startCrawlDate");
                        }
                        if (CliRuntime.WasSpecified(parseResult, EndCrawlDate))
                        {
                            __component1.AdditionalProperties?.Remove(@"endCrawlDate");
                        }
                        if (CliRuntime.WasSpecified(parseResult, StartPublishedDate))
                        {
                            __component1.AdditionalProperties?.Remove(@"startPublishedDate");
                        }
                        if (CliRuntime.WasSpecified(parseResult, EndPublishedDate))
                        {
                            __component1.AdditionalProperties?.Remove(@"endPublishedDate");
                        }
                        if (CliRuntime.WasSpecified(parseResult, IncludeText))
                        {
                            __component1.AdditionalProperties?.Remove(@"includeText");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ExcludeText))
                        {
                            __component1.AdditionalProperties?.Remove(@"excludeText");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Moderation))
                        {
                            __component1.AdditionalProperties?.Remove(@"moderation");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ContentsLivecrawlTimeout) || CliRuntime.WasSpecified(parseResult, ContentsMaxAgeHours) || CliRuntime.WasSpecified(parseResult, ContentsSubpages))
                        {
                            __component1.AdditionalProperties?.Remove(@"contents");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Query))
                        {
                            __component2.AdditionalProperties?.Remove(@"query");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AdditionalQueries))
                        {
                            __component2.AdditionalProperties?.Remove(@"additionalQueries");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Type))
                        {
                            __component2.AdditionalProperties?.Remove(@"type");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Category))
                        {
                            __component2.AdditionalProperties?.Remove(@"category");
                        }
                        if (CliRuntime.WasSpecified(parseResult, UserLocation))
                        {
                            __component2.AdditionalProperties?.Remove(@"userLocation");
                        }
                        var request = new global::Exa.AllOf<global::Exa.SearchRequest2, global::Exa.CommonRequest>(
                            __component1, __component2);

                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SearchAsync(

                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Exa.SourceGenerationContext.Default,
                                        @"Results",
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