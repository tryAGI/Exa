#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class MonitorsUpdateMonitorCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"The monitor ID",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Update the monitor name",
    };

    private static Option<global::Exa.UpdateSearchMonitorParametersStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Update the monitor status (can only set to `active` or `paused`)",
    };

    private static Option<global::Exa.UpdateSearchMonitorParametersSearch?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Partial search params to merge. All fields are optional for updates.",
    };

    private static Option<global::Exa.UpdateSearchMonitorParametersTrigger2?> Trigger { get; } = new(
        name: @"--trigger")
    {
        Description = @"Update the schedule. Set to null to remove the schedule.",
    };

    private static Option<global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>?> OutputSchema { get; } = new(
        name: @"--output-schema")
    {
        Description = @"Controls the format of the run output. Defaults to `{ ""type"": ""text"" }` if not specified. When `type` is `""text""`, the output is a plain text summary. When `type` is `""object""`, the output is structured JSON. If no `properties` are specified with `""object""` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Update metadata. Set to null to remove. Echoed back in webhook deliveries so you can route updates to systems like Slack.",
    };
    private static Option<string?> WebhookWebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = "Webhook target URL.",
    };

    private static Option<string[]> WebhookWebhookEvent { get; } = new(
        name: @"--webhook-event")
    {
        Description = @"Repeatable event name. Allowed values: monitor.created, monitor.updated, monitor.deleted, monitor.run.created, monitor.run.completed.",
        AllowMultipleArgumentsPerToken = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.SearchMonitor value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.SearchMonitor value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-monitor", @"Update a Monitor
Updates an existing monitor. All fields are optional. For `search`, you can send a partial object containing only the fields you want to change. Set `trigger` to `null` to remove the schedule.");
                        command.Arguments.Add(Id);
                        command.Options.Add(NameOption);
                        command.Options.Add(Status);
                        command.Options.Add(Search);
                        command.Options.Add(Trigger);
                        command.Options.Add(OutputSchema);
                        command.Options.Add(Metadata);
                        command.Options.Add(WebhookWebhookUrl);
                        command.Options.Add(WebhookWebhookEvent);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.UpdateSearchMonitorParameters>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);
                        var search = CliRuntime.WasSpecified(parseResult, Search) ? parseResult.GetValue(Search) : (__requestBase is { } __SearchBaseValue ? __SearchBaseValue.Search : default);
                        var trigger = CliRuntime.WasSpecified(parseResult, Trigger) ? parseResult.GetValue(Trigger) : (__requestBase is { } __TriggerBaseValue ? __TriggerBaseValue.Trigger : default);
                        var outputSchema = CliRuntime.WasSpecified(parseResult, OutputSchema) ? parseResult.GetValue(OutputSchema) : (__requestBase is { } __OutputSchemaBaseValue ? __OutputSchemaBaseValue.OutputSchema : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);


                        var __WebhookBase = __requestBase is { } __WebhookBaseValue ? __WebhookBaseValue.Webhook : default;
                        var webhookWebhookUrl = parseResult.GetValue(WebhookWebhookUrl) ?? __WebhookBase?.Url;
                        var __WebhookEventsSpecified = CliRuntime.WasSpecified(parseResult, WebhookWebhookEvent);
                        var webhookWebhookEvents = __WebhookEventsSpecified
                            ? CliRuntime.DeserializeJsonValue<global::System.Collections.Generic.IList<global::Exa.UpdateSearchMonitorParametersWebhookEvent>?>(
                                CliRuntime.SerializeStringArray(parseResult.GetValue(WebhookWebhookEvent) ?? Array.Empty<string>()),
                                global::Exa.SourceGenerationContext.Default)
                            : __WebhookBase?.Events;
                        var __WebhookSpecified = CliRuntime.WasSpecified(parseResult, WebhookWebhookUrl) || __WebhookEventsSpecified;
                        if (__WebhookSpecified && string.IsNullOrWhiteSpace(webhookWebhookUrl))
                        {
                            throw new CliException(@"Specify --webhook-url or include it in the base request body before using other --webhook-* options.");
                        }


                        var webhook =
                            __WebhookSpecified || __WebhookBase is not null
                                ? new global::Exa.UpdateSearchMonitorParametersWebhook
                                {

                                Url = webhookWebhookUrl,
                                Events = webhookWebhookEvents,
                                }
                                : __WebhookBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Monitors.UpdateMonitorAsync(
                                    id: id,
                                    name: name,
                                    status: status,
                                    search: search,
                                    trigger: trigger,
                                    outputSchema: outputSchema,
                                    metadata: metadata,
                                    webhook: webhook,
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