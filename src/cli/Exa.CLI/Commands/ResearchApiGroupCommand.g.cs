#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class ResearchApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"research", @"Research endpoint commands.");
                         command.Subcommands.Add(ResearchResearchControllerV0GetResearchTaskCommandApiCommand.Create());
                         command.Subcommands.Add(ResearchResearchTasksCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ResearchResearchTasksListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}