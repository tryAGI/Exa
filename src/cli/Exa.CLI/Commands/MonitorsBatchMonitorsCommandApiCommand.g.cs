#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class MonitorsBatchMonitorsCommandApiCommand
{
    private static Option<global::Exa.BatchMonitorsRequestAction> ActionOption { get; } = new(
        name: @"--action")
    {
        Description = @"The action to perform on matching monitors. `delete` permanently removes them, `pause` sets their status to paused, and `unpause` sets their status to active.",
        Required = true,
    };

    private static Option<global::Exa.BatchMonitorsRequestFilter> Filter { get; } = new(
        name: @"--filter")
    {
        Description = @"At least one filter field must be provided to prevent accidental bulk operations.",
        Required = true,
    };

    private static Option<bool?> DryRun { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dry-run",
        description: @"When `true`, returns the monitors that would be affected without performing the action. Defaults to `true`.");

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of monitors to process in a single request. Defaults to 50, maximum 500.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.BatchMonitorsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.BatchMonitorsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"batch-monitors", @"Batch action on monitors
Deletes, pauses, or unpauses the monitors that match the filter. Deletion is permanent. `dry_run` defaults to `true`, so a request only previews the affected monitors unless you set it to `false`. Repeat the request until `has_more` is `false` to process all matches.");
                        command.Options.Add(ActionOption);
                        command.Options.Add(Filter);
                        command.Options.Add(DryRun);
                        command.Options.Add(Limit);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.BatchMonitorsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var action = parseResult.GetRequiredValue(ActionOption);
                        var filter = parseResult.GetRequiredValue(Filter);
                        var dryRun = CliRuntime.WasSpecified(parseResult, DryRun) ? parseResult.GetValue(DryRun) : (__requestBase is { } __DryRunBaseValue ? __DryRunBaseValue.DryRun : default);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : (__requestBase is { } __LimitBaseValue ? __LimitBaseValue.Limit : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Monitors.BatchMonitorsAsync(
                                    action: action,
                                    filter: filter,
                                    dryRun: dryRun,
                                    limit: limit,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Exa.SourceGenerationContext.Default,
                                        @"Ids",
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