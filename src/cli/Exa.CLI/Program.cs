#nullable enable

using System.CommandLine;
using Exa.CLI;
using Exa.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the Exa SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(AgentApiGroupCommand.Create());
rootCommand.Subcommands.Add(DefaultApiGroupCommand.Create());
rootCommand.Subcommands.Add(EnrichmentsApiGroupCommand.Create());
rootCommand.Subcommands.Add(EventsApiGroupCommand.Create());
rootCommand.Subcommands.Add(ImportsApiGroupCommand.Create());
rootCommand.Subcommands.Add(ItemsApiGroupCommand.Create());
rootCommand.Subcommands.Add(MonitorsApiGroupCommand.Create());
rootCommand.Subcommands.Add(MonitorsRunsApiGroupCommand.Create());
rootCommand.Subcommands.Add(ResearchApiGroupCommand.Create());
rootCommand.Subcommands.Add(RunsApiGroupCommand.Create());
rootCommand.Subcommands.Add(SearchesApiGroupCommand.Create());
rootCommand.Subcommands.Add(TeamsApiGroupCommand.Create());
rootCommand.Subcommands.Add(WebhooksApiGroupCommand.Create());
rootCommand.Subcommands.Add(WebhooksAttemptsApiGroupCommand.Create());
rootCommand.Subcommands.Add(WebsetsApiGroupCommand.Create());
rootCommand.Subcommands.Add(WebsetsPreviewApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);