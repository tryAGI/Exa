#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class FindSimilarCommandApiCommand
{
    private static Argument<string> Url { get; } = new(
        name: @"url")
    {
        Description = @"The url for which you would like to find similar links.",
    };

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

    private static Option<int?> NumResults { get; } = new(
        name: @"--num-results")
    {
        Description = @"",
    };

    private static Option<global::Exa.FindSimilarRequestCategory2?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"",
    };

    private static Option<bool?> ExcludeSourceDomain { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--exclude-source-domain",
        description: @"");
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.FindSimilarResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.FindSimilarResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"find-similar", @"Find similar links
Find links similar to the provided URL and optionally retrieve their contents. Deprecated: prefer `/search` with a query describing the source.");
                        command.Arguments.Add(Url);
                        command.Options.Add(IncludeDomains);
                        command.Options.Add(ExcludeDomains);
                        command.Options.Add(StartCrawlDate);
                        command.Options.Add(EndCrawlDate);
                        command.Options.Add(StartPublishedDate);
                        command.Options.Add(EndPublishedDate);
                        command.Options.Add(NumResults);
                        command.Options.Add(Category);
                        command.Options.Add(ExcludeSourceDomain);                        command.Options.Add(ContentsOptions.LivecrawlTimeout);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.FindSimilarRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var url = parseResult.GetRequiredValue(Url);
                        var includeDomains = CliRuntime.WasSpecified(parseResult, IncludeDomains) ? parseResult.GetValue(IncludeDomains) : (__requestBase is { } __IncludeDomainsBaseValue ? __IncludeDomainsBaseValue.IncludeDomains : default);
                        var excludeDomains = CliRuntime.WasSpecified(parseResult, ExcludeDomains) ? parseResult.GetValue(ExcludeDomains) : (__requestBase is { } __ExcludeDomainsBaseValue ? __ExcludeDomainsBaseValue.ExcludeDomains : default);
                        var startCrawlDate = CliRuntime.WasSpecified(parseResult, StartCrawlDate) ? parseResult.GetValue(StartCrawlDate) : (__requestBase is { } __StartCrawlDateBaseValue ? __StartCrawlDateBaseValue.StartCrawlDate : default);
                        var endCrawlDate = CliRuntime.WasSpecified(parseResult, EndCrawlDate) ? parseResult.GetValue(EndCrawlDate) : (__requestBase is { } __EndCrawlDateBaseValue ? __EndCrawlDateBaseValue.EndCrawlDate : default);
                        var startPublishedDate = CliRuntime.WasSpecified(parseResult, StartPublishedDate) ? parseResult.GetValue(StartPublishedDate) : (__requestBase is { } __StartPublishedDateBaseValue ? __StartPublishedDateBaseValue.StartPublishedDate : default);
                        var endPublishedDate = CliRuntime.WasSpecified(parseResult, EndPublishedDate) ? parseResult.GetValue(EndPublishedDate) : (__requestBase is { } __EndPublishedDateBaseValue ? __EndPublishedDateBaseValue.EndPublishedDate : default);
                        var numResults = CliRuntime.WasSpecified(parseResult, NumResults) ? parseResult.GetValue(NumResults) : (__requestBase is { } __NumResultsBaseValue ? __NumResultsBaseValue.NumResults : default);
                        var category = CliRuntime.WasSpecified(parseResult, Category) ? parseResult.GetValue(Category) : (__requestBase is { } __CategoryBaseValue ? __CategoryBaseValue.Category : default);
                        var excludeSourceDomain = CliRuntime.WasSpecified(parseResult, ExcludeSourceDomain) ? parseResult.GetValue(ExcludeSourceDomain) : (__requestBase is { } __ExcludeSourceDomainBaseValue ? __ExcludeSourceDomainBaseValue.ExcludeSourceDomain : default);

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


                                var response = await client.FindSimilarAsync(
                                    url: url,
                                    includeDomains: includeDomains,
                                    excludeDomains: excludeDomains,
                                    startCrawlDate: startCrawlDate,
                                    endCrawlDate: endCrawlDate,
                                    startPublishedDate: startPublishedDate,
                                    endPublishedDate: endPublishedDate,
                                    numResults: numResults,
                                    category: category,
                                    excludeSourceDomain: excludeSourceDomain,
                                    contents: contents,
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
        return command;
    }
}