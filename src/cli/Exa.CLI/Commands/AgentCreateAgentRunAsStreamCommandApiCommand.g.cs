#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class AgentCreateAgentRunAsStreamCommandApiCommand
{
    private static Option<global::Exa.CreateAgentRunAccept?> Accept { get; } = new(
        name: @"--accept")
    {
        Description = @"Set to `text/event-stream` to receive server-sent events.",
    };

    private static Option<string?> ExaBeta { get; } = new(
        name: @"--exa-beta")
    {
        Description = @"Comma-separated beta feature tokens for opting into experimental features.",
    };

    private static Option<global::Exa.CreateAgentRunRequestInput?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Records to process and records or entities to exclude from the answer.",
    };

    private static Option<object?> OutputSchema { get; } = new(
        name: @"--output-schema")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Caller-provided metadata stored with the run.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Exa.AgentDataSource>?> DataSources { get; } = new(
        name: @"--data-sources")
    {
        Description = @"Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.",
    };
    private static readonly CreateAgentRunRequestOptionSet CreateAgentRunRequestOptionSetOptions = CreateAgentRunRequestOptionSet.Create();
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

    public static Command Create()
    {
        var command = new Command(@"create-agent-run-as-stream", @"Create a run
Create an asynchronous Agent run. By default, the API returns the run object immediately. Set `Accept: text/event-stream` to stream run lifecycle events until the run reaches a terminal status.");
                        command.Options.Add(Accept);
                        command.Options.Add(ExaBeta);
                        command.Options.Add(InputOption);
                        command.Options.Add(OutputSchema);
                        command.Options.Add(Metadata);
                        command.Options.Add(DataSources);                        command.Options.Add(CreateAgentRunRequestOptionSetOptions.Query);
                        command.Options.Add(CreateAgentRunRequestOptionSetOptions.SystemPrompt);
                        command.Options.Add(CreateAgentRunRequestOptionSetOptions.Effort);
                        command.Options.Add(CreateAgentRunRequestOptionSetOptions.PreviousRunId);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Exa.CreateAgentRunRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Exa.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var accept = parseResult.GetValue(Accept);
                        var exaBeta = parseResult.GetValue(ExaBeta);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);
                        var outputSchema = CliRuntime.WasSpecified(parseResult, OutputSchema) ? parseResult.GetValue(OutputSchema) : (__requestBase is { } __OutputSchemaBaseValue ? __OutputSchemaBaseValue.OutputSchema : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var dataSources = CliRuntime.WasSpecified(parseResult, DataSources) ? parseResult.GetValue(DataSources) : (__requestBase is { } __DataSourcesBaseValue ? __DataSourcesBaseValue.DataSources : default);                        var query = parseResult.GetRequiredValue(CreateAgentRunRequestOptionSetOptions.Query);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, CreateAgentRunRequestOptionSetOptions.SystemPrompt) ? parseResult.GetValue(CreateAgentRunRequestOptionSetOptions.SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);
                        var effort = CliRuntime.WasSpecified(parseResult, CreateAgentRunRequestOptionSetOptions.Effort) ? parseResult.GetValue(CreateAgentRunRequestOptionSetOptions.Effort) : (__requestBase is { } __EffortBaseValue ? __EffortBaseValue.Effort : default);
                        var previousRunId = CliRuntime.WasSpecified(parseResult, CreateAgentRunRequestOptionSetOptions.PreviousRunId) ? parseResult.GetValue(CreateAgentRunRequestOptionSetOptions.PreviousRunId) : (__requestBase is { } __PreviousRunIdBaseValue ? __PreviousRunIdBaseValue.PreviousRunId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Agent.CreateAgentRunAsStreamAsync(
                                    accept: accept,
                                    exaBeta: exaBeta,
                                    input: input,
                                    outputSchema: outputSchema,
                                    metadata: metadata,
                                    dataSources: dataSources,
                                    query: query,
                                    systemPrompt: systemPrompt,
                                    effort: effort,
                                    previousRunId: previousRunId,
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::Exa.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}