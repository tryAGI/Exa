#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class TeamsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"teams", @"Teams endpoint commands.");
                         command.Subcommands.Add(TeamsTeamsMeGetCommandApiCommand.Create());
        return command;
    }
}