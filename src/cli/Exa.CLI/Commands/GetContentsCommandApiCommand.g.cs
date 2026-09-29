#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class GetContentsCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>> Urls { get; } = new(
        name: @"--urls")
    {
        Description = @"Array of URLs to crawl (backwards compatible with 'ids' parameter).",
    };

    private static Option<string?> SummaryQuery { get; } = new(
        name: @"--summary-query")
    {
        Description = @"Custom query for the LLM-generated summary.",
    };

    private static Option<int?> LivecrawlTimeout { get; } = new(
        name: @"--livecrawl-timeout")
    {
        Description = @"The timeout for livecrawling in milliseconds.",
    };

    private static Option<int?> MaxAgeHours { get; } = new(
        name: @"--max-age-hours")
    {
        Description = @"Maximum age of cached content in hours. Controls when livecrawling is triggered based on content freshness.
- Positive value (e.g. 24): Use cached content if it's less than this many hours old, otherwise livecrawl.
- 0: Always livecrawl, never use cache.
- -1: Never livecrawl, always use cache.
- Omit (default): Livecrawl as fallback only when no cached content exists.
",
    };

    private static Option<int?> Subpages { get; } = new(
        name: @"--subpages")
    {
        Description = @"The number of subpages to crawl. The actual number crawled may be limited by system constraints.",
    };

    private static Option<int?> ExtrasLinks { get; } = new(
        name: @"--extras-links")
    {
        Description = @"Number of URLs to return from each webpage.",
    };

    private static Option<int?> ExtrasImageLinks { get; } = new(
        name: @"--extras-image-links")
    {
        Description = @"Number of images to return for each result.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.GetContentsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.GetContentsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-contents", @"Get Contents");
                        command.Options.Add(Urls);
                        command.Options.Add(SummaryQuery);
                        command.Options.Add(LivecrawlTimeout);
                        command.Options.Add(MaxAgeHours);
                        command.Options.Add(Subpages);
                        command.Options.Add(ExtrasLinks);
                        command.Options.Add(ExtrasImageLinks);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.AllOf<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest>>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var urls = (CliRuntime.WasSpecified(parseResult, Urls)
                            ? parseResult.GetValue(Urls)
                            : __requestBase.Value1?.Urls)
                            ?? throw new CliException(@"Specify urls or include it in the base request body.");
                        var summaryQuery = CliRuntime.WasSpecified(parseResult, SummaryQuery) ? parseResult.GetValue(SummaryQuery) : (__requestBase is { } __SummaryQueryBaseValue ? __SummaryQueryBaseValue.Value2?.Summary?.Query : default);
                        var livecrawlTimeout = CliRuntime.WasSpecified(parseResult, LivecrawlTimeout) ? parseResult.GetValue(LivecrawlTimeout) : (__requestBase is { } __LivecrawlTimeoutBaseValue ? __LivecrawlTimeoutBaseValue.Value2?.LivecrawlTimeout : default);
                        var maxAgeHours = CliRuntime.WasSpecified(parseResult, MaxAgeHours) ? parseResult.GetValue(MaxAgeHours) : (__requestBase is { } __MaxAgeHoursBaseValue ? __MaxAgeHoursBaseValue.Value2?.MaxAgeHours : default);
                        var subpages = CliRuntime.WasSpecified(parseResult, Subpages) ? parseResult.GetValue(Subpages) : (__requestBase is { } __SubpagesBaseValue ? __SubpagesBaseValue.Value2?.Subpages : default);
                        var extrasLinks = CliRuntime.WasSpecified(parseResult, ExtrasLinks) ? parseResult.GetValue(ExtrasLinks) : (__requestBase is { } __ExtrasLinksBaseValue ? __ExtrasLinksBaseValue.Value2?.Extras?.Links : default);
                        var extrasImageLinks = CliRuntime.WasSpecified(parseResult, ExtrasImageLinks) ? parseResult.GetValue(ExtrasImageLinks) : (__requestBase is { } __ExtrasImageLinksBaseValue ? __ExtrasImageLinksBaseValue.Value2?.Extras?.ImageLinks : default);
                        var __component1 = __requestBase.Value1 ?? new global::Exa.GetContentsRequest2 { Urls = urls! };
                        __component1.Urls = urls;

                        var __component2 = __requestBase.Value2 ?? new global::Exa.ContentsRequest();
                        __component2.LivecrawlTimeout = livecrawlTimeout;
                        __component2.MaxAgeHours = maxAgeHours;
                        __component2.Subpages = subpages;
                        if (CliRuntime.WasSpecified(parseResult, SummaryQuery))
                        {
                            __component2.Summary ??= new global::Exa.ContentsRequestSummary();
                            if (CliRuntime.WasSpecified(parseResult, SummaryQuery))
                            {
                                __component2.Summary.Query = summaryQuery;
                            }
                        }
                        if (CliRuntime.WasSpecified(parseResult, ExtrasLinks) || CliRuntime.WasSpecified(parseResult, ExtrasImageLinks))
                        {
                            __component2.Extras ??= new global::Exa.ContentsRequestExtras();
                            if (CliRuntime.WasSpecified(parseResult, ExtrasLinks))
                            {
                                __component2.Extras.Links = extrasLinks;
                            }
                            if (CliRuntime.WasSpecified(parseResult, ExtrasImageLinks))
                            {
                                __component2.Extras.ImageLinks = extrasImageLinks;
                            }
                        }
                        if (CliRuntime.WasSpecified(parseResult, SummaryQuery))
                        {
                            __component1.AdditionalProperties?.Remove(@"summary");
                        }
                        if (CliRuntime.WasSpecified(parseResult, LivecrawlTimeout))
                        {
                            __component1.AdditionalProperties?.Remove(@"livecrawlTimeout");
                        }
                        if (CliRuntime.WasSpecified(parseResult, MaxAgeHours))
                        {
                            __component1.AdditionalProperties?.Remove(@"maxAgeHours");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Subpages))
                        {
                            __component1.AdditionalProperties?.Remove(@"subpages");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ExtrasLinks) || CliRuntime.WasSpecified(parseResult, ExtrasImageLinks))
                        {
                            __component1.AdditionalProperties?.Remove(@"extras");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Urls))
                        {
                            __component2.AdditionalProperties?.Remove(@"urls");
                        }
                        var request = new global::Exa.AllOf<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest>(
                            __component1, __component2);

                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetContentsAsync(

                                    request: request,
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