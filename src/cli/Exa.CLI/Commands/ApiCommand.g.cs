#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(ResearchApiGroupCommand.Create());
        return command;
    }
}