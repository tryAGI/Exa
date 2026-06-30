#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class GetContentsCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> Ids { get; } = new(
        name: @"--ids")
    {
        Description = @"Document IDs obtained from searches.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Urls { get; } = new(
        name: @"--urls")
    {
        Description = @"URLs to crawl (backwards compatible with the `ids` parameter).",
    };

    private static Option<global::Exa.ContentsRequestCompliance2?> Compliance { get; } = new(
        name: @"--compliance")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>?> Text { get; } = new(
        name: @"--text")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>?> Highlights { get; } = new(
        name: @"--highlights")
    {
        Description = @"",
    };

    private static Option<global::Exa.ContentsRequestSummary2?> Summary { get; } = new(
        name: @"--summary")
    {
        Description = @"",
    };

    private static Option<global::Exa.ContentsRequestExtras2?> Extras { get; } = new(
        name: @"--extras")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>?> Context { get; } = new(
        name: @"--context")
    {
        Description = @"",
    };

    private static Option<global::Exa.ContentsRequestLivecrawl2?> Livecrawl { get; } = new(
        name: @"--livecrawl")
    {
        Description = @"",
    };

    private static Option<int?> LivecrawlTimeout { get; } = new(
        name: @"--livecrawl-timeout")
    {
        Description = @"",
    };

    private static Option<int?> MaxAgeHours { get; } = new(
        name: @"--max-age-hours")
    {
        Description = @"",
    };

    private static Option<int?> Subpages { get; } = new(
        name: @"--subpages")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>?> SubpageTarget { get; } = new(
        name: @"--subpage-target")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.ContentsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.ContentsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-contents", @"Contents");
                        command.Options.Add(Ids);
                        command.Options.Add(Urls);
                        command.Options.Add(Compliance);
                        command.Options.Add(Text);
                        command.Options.Add(Highlights);
                        command.Options.Add(Summary);
                        command.Options.Add(Extras);
                        command.Options.Add(Context);
                        command.Options.Add(Livecrawl);
                        command.Options.Add(LivecrawlTimeout);
                        command.Options.Add(MaxAgeHours);
                        command.Options.Add(Subpages);
                        command.Options.Add(SubpageTarget);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.ContentsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var ids = CliRuntime.WasSpecified(parseResult, Ids) ? parseResult.GetValue(Ids) : (__requestBase is { } __IdsBaseValue ? __IdsBaseValue.Ids : default);
                        var urls = CliRuntime.WasSpecified(parseResult, Urls) ? parseResult.GetValue(Urls) : (__requestBase is { } __UrlsBaseValue ? __UrlsBaseValue.Urls : default);
                        var compliance = CliRuntime.WasSpecified(parseResult, Compliance) ? parseResult.GetValue(Compliance) : (__requestBase is { } __ComplianceBaseValue ? __ComplianceBaseValue.Compliance : default);
                        var text = CliRuntime.WasSpecified(parseResult, Text) ? parseResult.GetValue(Text) : (__requestBase is { } __TextBaseValue ? __TextBaseValue.Text : default);
                        var highlights = CliRuntime.WasSpecified(parseResult, Highlights) ? parseResult.GetValue(Highlights) : (__requestBase is { } __HighlightsBaseValue ? __HighlightsBaseValue.Highlights : default);
                        var summary = CliRuntime.WasSpecified(parseResult, Summary) ? parseResult.GetValue(Summary) : (__requestBase is { } __SummaryBaseValue ? __SummaryBaseValue.Summary : default);
                        var extras = CliRuntime.WasSpecified(parseResult, Extras) ? parseResult.GetValue(Extras) : (__requestBase is { } __ExtrasBaseValue ? __ExtrasBaseValue.Extras : default);
                        var context = CliRuntime.WasSpecified(parseResult, Context) ? parseResult.GetValue(Context) : (__requestBase is { } __ContextBaseValue ? __ContextBaseValue.Context : default);
                        var livecrawl = CliRuntime.WasSpecified(parseResult, Livecrawl) ? parseResult.GetValue(Livecrawl) : (__requestBase is { } __LivecrawlBaseValue ? __LivecrawlBaseValue.Livecrawl : default);
                        var livecrawlTimeout = CliRuntime.WasSpecified(parseResult, LivecrawlTimeout) ? parseResult.GetValue(LivecrawlTimeout) : (__requestBase is { } __LivecrawlTimeoutBaseValue ? __LivecrawlTimeoutBaseValue.LivecrawlTimeout : default);
                        var maxAgeHours = CliRuntime.WasSpecified(parseResult, MaxAgeHours) ? parseResult.GetValue(MaxAgeHours) : (__requestBase is { } __MaxAgeHoursBaseValue ? __MaxAgeHoursBaseValue.MaxAgeHours : default);
                        var subpages = CliRuntime.WasSpecified(parseResult, Subpages) ? parseResult.GetValue(Subpages) : (__requestBase is { } __SubpagesBaseValue ? __SubpagesBaseValue.Subpages : default);
                        var subpageTarget = CliRuntime.WasSpecified(parseResult, SubpageTarget) ? parseResult.GetValue(SubpageTarget) : (__requestBase is { } __SubpageTargetBaseValue ? __SubpageTargetBaseValue.SubpageTarget : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetContentsAsync(
                                    ids: ids,
                                    urls: urls,
                                    compliance: compliance,
                                    text: text,
                                    highlights: highlights,
                                    summary: summary,
                                    extras: extras,
                                    context: context,
                                    livecrawl: livecrawl,
                                    livecrawlTimeout: livecrawlTimeout,
                                    maxAgeHours: maxAgeHours,
                                    subpages: subpages,
                                    subpageTarget: subpageTarget,
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