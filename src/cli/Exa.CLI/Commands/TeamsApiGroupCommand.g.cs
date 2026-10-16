#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class TeamsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"teams", @"Teams endpoint commands.");
                         command.Subcommands.Add(TeamsTeamsMeGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}