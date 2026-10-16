#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class ImportsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"imports", @"Imports endpoint commands.");
                         command.Subcommands.Add(ImportsImportsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ImportsImportsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ImportsImportsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ImportsImportsListCommandApiCommand.Create());
                         command.Subcommands.Add(ImportsImportsUpdateCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}