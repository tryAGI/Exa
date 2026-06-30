#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class AgentApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agent", @"Agent endpoint commands.");
                         command.Subcommands.Add(AgentCancelAgentRunCommandApiCommand.Create());
                         command.Subcommands.Add(AgentCreateAgentRunCommandApiCommand.Create());
                         command.Subcommands.Add(AgentCreateAgentRunAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(AgentDeleteAgentRunCommandApiCommand.Create());
                         command.Subcommands.Add(AgentGetAgentRunCommandApiCommand.Create());
                         command.Subcommands.Add(AgentListAgentRunEventsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentListAgentRunEventsAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(AgentListAgentRunsCommandApiCommand.Create());
        return command;
    }
}