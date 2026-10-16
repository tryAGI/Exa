#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class SearchesWebsetsSearchesCreateCommandApiCommand
{
    private static Argument<string> Webset { get; } = new(
        name: @"webset")
    {
        Description = @"The id of the Webset",
    };

    private static Option<double> Count { get; } = new(
        name: @"--count")
    {
        Description = @"Number of Items the Search will attempt to find.

The actual number of Items found may be less than this number depending on the query complexity.",
        Required = true,
    };

    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Natural language search query describing what you are looking for.

Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.

Any URLs provided will be crawled and used as additional context for the search.",
        Required = true,
    };

    private static Option<global::Exa.Entity?> Entity { get; } = new(
        name: @"--entity")
    {
        Description = @"Entity the search returns results for. Detected from the query when omitted.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>?> Criteria { get; } = new(
        name: @"--criteria")
    {
        Description = @"Criteria every Item is evaluated against. Generated from the query when omitted.",
    };

    private static Option<int?> MaxPeoplePerCompany { get; } = new(
        name: @"--max-people-per-company")
    {
        Description = @"Optional soft cap for people searches. When set, the search will try to include at most this many matching people from the same current employer company.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>?> Exclude { get; } = new(
        name: @"--exclude")
    {
        Description = @"Imports or Websets whose items are left out of this search's results.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>?> Scope { get; } = new(
        name: @"--scope")
    {
        Description = @"Limit the search to specific sources (existing imports). Any results found within these sources matching the search criteria will be included in the Webset.",
    };

    private static Option<bool?> Recall { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--recall",
        description: @"Whether to estimate how many relevant results exist for this search. The estimate is returned in the search's `recall` field.");

    private static Option<global::Exa.WebsetSearchBehavior?> Behavior { get; } = new(
        name: @"--behavior")
    {
        Description = @"How this search interacts with existing items in the Webset:

- **override**: Replace existing items and evaluate all items against new criteria
- **append**: Add new items to existing ones, keeping items that match the new criteria",
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
      private static Option<bool> Wait { get; } = new("--wait")
      {
          Description = "Poll the generated wait helper until the resource reaches a terminal state.",
      };

      private static Option<string> PollInterval { get; } = new("--poll-interval")
      {
          Description = "Polling interval, for example 250ms, 2s, 30m, or 01:00:00.",
          DefaultValueFactory = _ => "2s",
      };

      private static Option<string> WaitTimeout { get; } = new("--wait-timeout")
      {
          Description = "Maximum time to wait before timing out, for example 30m or 00:30:00.",
          DefaultValueFactory = _ => "30m",
      };

                    private static string FormatResponse(ParseResult parseResult, global::Exa.WebsetSearch value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.WebsetSearch value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"websets-searches-create", @"Create a Search
Creates a new Search for the Webset.

The default behavior is to reuse the previous Search results and evaluate them against the new criteria.");
                        command.Arguments.Add(Webset);
                        command.Options.Add(Count);
                        command.Options.Add(Query);
                        command.Options.Add(Entity);
                        command.Options.Add(Criteria);
                        command.Options.Add(MaxPeoplePerCompany);
                        command.Options.Add(Exclude);
                        command.Options.Add(Scope);
                        command.Options.Add(Recall);
                        command.Options.Add(Behavior);
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
          command.Options.Add(Wait);
          command.Options.Add(PollInterval);
          command.Options.Add(WaitTimeout);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.CreateWebsetSearchParameters>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var webset = parseResult.GetRequiredValue(Webset);
                        var count = parseResult.GetRequiredValue(Count);
                        var query = parseResult.GetRequiredValue(Query);
                        var entity = CliRuntime.WasSpecified(parseResult, Entity) ? parseResult.GetValue(Entity) : (__requestBase is { } __EntityBaseValue ? __EntityBaseValue.Entity : default);
                        var criteria = CliRuntime.WasSpecified(parseResult, Criteria) ? parseResult.GetValue(Criteria) : (__requestBase is { } __CriteriaBaseValue ? __CriteriaBaseValue.Criteria : default);
                        var maxPeoplePerCompany = CliRuntime.WasSpecified(parseResult, MaxPeoplePerCompany) ? parseResult.GetValue(MaxPeoplePerCompany) : (__requestBase is { } __MaxPeoplePerCompanyBaseValue ? __MaxPeoplePerCompanyBaseValue.MaxPeoplePerCompany : default);
                        var exclude = CliRuntime.WasSpecified(parseResult, Exclude) ? parseResult.GetValue(Exclude) : (__requestBase is { } __ExcludeBaseValue ? __ExcludeBaseValue.Exclude : default);
                        var scope = CliRuntime.WasSpecified(parseResult, Scope) ? parseResult.GetValue(Scope) : (__requestBase is { } __ScopeBaseValue ? __ScopeBaseValue.Scope : default);
                        var recall = CliRuntime.WasSpecified(parseResult, Recall) ? parseResult.GetValue(Recall) : (__requestBase is { } __RecallBaseValue ? __RecallBaseValue.Recall : default);
                        var behavior = CliRuntime.WasSpecified(parseResult, Behavior) ? parseResult.GetValue(Behavior) : (__requestBase is { } __BehaviorBaseValue ? __BehaviorBaseValue.Behavior : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.Searches.WebsetsSearchesCreateAsync(
                                    webset: webset,
                                    count: count,
                                    query: query,
                                    entity: entity,
                                    criteria: criteria,
                                    maxPeoplePerCompany: maxPeoplePerCompany,
                                    exclude: exclude,
                                    scope: scope,
                                    recall: recall,
                                    behavior: behavior,
                                    metadata: metadata,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.Searches.WebsetsSearchesGetAsync(
                                            webset: webset,
                                            id: resourceId,
                                            cancellationToken: token),
                                        pollInterval: pollInterval,
                                        waitTimeout: waitTimeout,
                                        context: global::Exa.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    await CliRuntime.WriteResponseAsync(
                                        parseResult,
                                        waitResponse,
                                        global::Exa.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    return;
                                }

                                var response = await client.Searches.WebsetsSearchesCreateAsync(
                                    webset: webset,
                                    count: count,
                                    query: query,
                                    entity: entity,
                                    criteria: criteria,
                                    maxPeoplePerCompany: maxPeoplePerCompany,
                                    exclude: exclude,
                                    scope: scope,
                                    recall: recall,
                                    behavior: behavior,
                                    metadata: metadata,
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