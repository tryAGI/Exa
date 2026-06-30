#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class ResearchApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"research", @"Research endpoint commands.");
                         command.Subcommands.Add(ResearchResearchControllerCreateResearchCommandApiCommand.Create());
                         command.Subcommands.Add(ResearchResearchControllerGetResearchCommandApiCommand.Create());
                         command.Subcommands.Add(ResearchResearchControllerListResearchCommandApiCommand.Create());
        return command;
    }
}