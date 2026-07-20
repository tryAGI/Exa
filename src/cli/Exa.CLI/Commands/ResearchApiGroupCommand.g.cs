#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class ResearchApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"research", @"Research endpoint commands.");
                         command.Subcommands.Add(ResearchResearchControllerV0GetResearchTaskCommandApiCommand.Create());
                         command.Subcommands.Add(ResearchResearchTasksCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ResearchResearchTasksListCommandApiCommand.Create());
        return command;
    }
}