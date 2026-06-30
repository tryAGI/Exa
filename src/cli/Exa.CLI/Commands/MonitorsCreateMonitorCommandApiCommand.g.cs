#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class MonitorsCreateMonitorCommandApiCommand
{
    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"An optional name for the monitor",
    };

    private static Option<global::Exa.SearchMonitorSearch> Search { get; } = new(
        name: @"--search")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::Exa.SearchMonitorTrigger?> Trigger { get; } = new(
        name: @"--trigger")
    {
        Description = @"",
    };

    private static Option<global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>?> OutputSchema { get; } = new(
        name: @"--output-schema")
    {
        Description = @"Controls the format of the run output. Defaults to `{ ""type"": ""text"" }` if not specified. When `type` is `""text""`, the output is a plain text summary. When `type` is `""object""`, the output is structured JSON. If no `properties` are specified with `""object""` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Optional key-value metadata. Echoed back in webhook deliveries so you can route updates to systems like Slack.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Exa.CreateSearchMonitorResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Exa.CreateSearchMonitorResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-monitor", @"Create a Monitor
Creates a new Monitor to run recurring Exa searches on a schedule.

Monitors automatically execute your search query on a recurring schedule and deliver results to your webhook endpoint with automatic deduplication:

- **Date-based filtering** only fetches content since the last run

- **Semantic deduplication** tracks previous outputs to surface only new developments

The response includes a `webhookSecret` that is only returned once at creation time. Store it securely for webhook signature verification.");
                        command.Options.Add(NameOption);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.CreateSearchMonitorParameters>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var search = parseResult.GetRequiredValue(Search);
                        var trigger = CliRuntime.WasSpecified(parseResult, Trigger) ? parseResult.GetValue(Trigger) : (__requestBase is { } __TriggerBaseValue ? __TriggerBaseValue.Trigger : default);
                        var outputSchema = CliRuntime.WasSpecified(parseResult, OutputSchema) ? parseResult.GetValue(OutputSchema) : (__requestBase is { } __OutputSchemaBaseValue ? __OutputSchemaBaseValue.OutputSchema : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);


                        var __WebhookBase = __requestBase is { } __WebhookBaseValue ? __WebhookBaseValue.Webhook : default;
                        var webhookWebhookUrl = parseResult.GetValue(WebhookWebhookUrl) ?? __WebhookBase?.Url;
                        var __WebhookEventsSpecified = CliRuntime.WasSpecified(parseResult, WebhookWebhookEvent);
                        var webhookWebhookEvents = __WebhookEventsSpecified
                            ? CliRuntime.DeserializeJsonValue<global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookEvent>?>(
                                CliRuntime.SerializeStringArray(parseResult.GetValue(WebhookWebhookEvent) ?? Array.Empty<string>()),
                                global::Exa.SourceGenerationContext.Default)
                            : __WebhookBase?.Events;
                        var __WebhookSpecified = CliRuntime.WasSpecified(parseResult, WebhookWebhookUrl) || __WebhookEventsSpecified;
                        if (__WebhookSpecified && string.IsNullOrWhiteSpace(webhookWebhookUrl))
                        {
                            throw new CliException("Specify --webhook-url or include it in the base request body before using other --webhook-* options.");
                        }

                        var __webhookWebhookUrlRequired =
                            webhookWebhookUrl ??
                            throw new CliException("Specify --webhook-url or include it in the base request body before using other --webhook-* options.");

                        var webhook =
                            __WebhookSpecified || __WebhookBase is not null
                                ? new global::Exa.SearchMonitorWebhook
                                {

                                Url = __webhookWebhookUrlRequired,
                                Events = webhookWebhookEvents,
                                }
                                : __WebhookBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Monitors.CreateMonitorAsync(
                                    name: name,
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