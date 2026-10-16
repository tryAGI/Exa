#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class MonitorsMonitorsUpdateCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"The id of the Monitor",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<global::Exa.UpdateMonitorStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"The status of the monitor.",
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
        var command = new Command(commandName ?? @"update", @"Update Monitor
Updates a monitor configuration.");
                        command.Arguments.Add(Id);
                        command.Options.Add(Metadata);
                        command.Options.Add(Status);                        command.Options.Add(CadenceOptions.Cron);
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

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.UpdateMonitor>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);

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

                        var __BehaviorBase = __requestBase is { } __BehaviorBaseValue ? __BehaviorBaseValue.Behavior : default;                        var behaviorType = parseResult.GetValue(BehaviorOptions.Type);
                        var __BehaviorSpecified = CliRuntime.WasSpecified(parseResult, BehaviorOptions.Type);
                        var behavior =
                            __BehaviorSpecified || __BehaviorBase is not null
                                ? new global::Exa.MonitorBehavior
                                {
	                                Type = behaviorType,
	                                Config = __BehaviorBase is not null ? __BehaviorBase.Config : throw new CliException(@"Behavior.config is required when using behavior options. Provide it with --request-json or --request-file."),
                                }
                                : __BehaviorBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Monitors.MonitorsUpdateAsync(
                                    id: id,
                                    metadata: metadata,
                                    status: status,
                                    cadence: cadence,
                                    behavior: behavior,
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