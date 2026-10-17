#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class MonitorsMonitorsCreateCommandApiCommand
{
    private static Option<string> WebsetId { get; } = new(
        name: @"--webset-id")
    {
        Description = @"The id of the Webset",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };
    private static readonly MonitorCadenceOptionSet CadenceOptions = MonitorCadenceOptionSet.Create(@"cadence");

    private static readonly MonitorBehaviorOptionSet BehaviorOptions = MonitorBehaviorOptionSet.Create(@"behavior");
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.Monitor value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.Monitor value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create", @"Create a Monitor
Creates a Monitor that searches for new Items for a Webset on a `cron` schedule in the given `timezone`.");
                        command.Options.Add(WebsetId);
                        command.Options.Add(Metadata);                        command.Options.Add(CadenceOptions.Cron);
                        command.Options.Add(CadenceOptions.Timezone);                        command.Options.Add(BehaviorOptions.Type);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.CreateMonitorParameters>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var websetId = parseResult.GetRequiredValue(WebsetId);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);

                        var __CadenceBase = __requestBase is { } __CadenceBaseValue ? __CadenceBaseValue.Cadence : default;                        var cadenceCron = parseResult.GetValue(CadenceOptions.Cron);
                        var cadenceTimezone = CliRuntime.WasSpecified(parseResult, CadenceOptions.Timezone) ? parseResult.GetValue(CadenceOptions.Timezone) : (__CadenceBase is { } __CadencetimezoneBaseValue ? __CadencetimezoneBaseValue.Timezone : default);
                        var __CadenceSpecified = CliRuntime.WasSpecified(parseResult, CadenceOptions.Cron) || CliRuntime.WasSpecified(parseResult, CadenceOptions.Timezone);
                        var cadence =
                            __CadenceSpecified || __CadenceBase is not null
                                ? new global::Exa.MonitorCadence
                                {
	                                Cron = cadenceCron!,
                                Timezone = cadenceTimezone,

                                }
                                : __CadenceBase;

                        var __BehaviorBase = __requestBase is { } __BehaviorBaseValue ? __BehaviorBaseValue.Behavior : default;                        var behaviorType = parseResult.GetRequiredValue(BehaviorOptions.Type);
                        var __BehaviorSpecified = CliRuntime.WasSpecified(parseResult, BehaviorOptions.Type);
                        var behavior =
                            __BehaviorSpecified || __BehaviorBase is not null
                                ? new global::Exa.MonitorBehavior
                                {
	                                Type = behaviorType,
	                                Config = __BehaviorBase is not null ? __BehaviorBase.Config : throw new CliException(@"Behavior.config is required when using behavior options. Provide it with --request-json or --request-file."),
                                }
                                : __BehaviorBase;          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.Monitors.MonitorsCreateAsync(
                                    websetId: websetId,
                                    metadata: metadata,
                                    cadence: cadence!,
                                    behavior: behavior!,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.Monitors.MonitorsGetAsync(
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

                                var response = await client.Monitors.MonitorsCreateAsync(
                                    websetId: websetId,
                                    metadata: metadata,
                                    cadence: cadence!,
                                    behavior: behavior!,
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