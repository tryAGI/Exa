#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AgentApiGroupCommand.Create());
                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(EnrichmentsApiGroupCommand.Create());
                         command.Subcommands.Add(EventsApiGroupCommand.Create());
                         command.Subcommands.Add(ImportsApiGroupCommand.Create());
                         command.Subcommands.Add(ItemsApiGroupCommand.Create());
                         command.Subcommands.Add(MonitorsApiGroupCommand.Create());
                         command.Subcommands.Add(MonitorsRunsApiGroupCommand.Create());
                         command.Subcommands.Add(ResearchApiGroupCommand.Create());
                         command.Subcommands.Add(RunsApiGroupCommand.Create());
                         command.Subcommands.Add(SearchesApiGroupCommand.Create());
                         command.Subcommands.Add(TeamsApiGroupCommand.Create());
                         command.Subcommands.Add(WebhooksApiGroupCommand.Create());
                         command.Subcommands.Add(WebhooksAttemptsApiGroupCommand.Create());
                         command.Subcommands.Add(WebsetsApiGroupCommand.Create());
                         command.Subcommands.Add(WebsetsPreviewApiGroupCommand.Create());
        return command;
    }
}