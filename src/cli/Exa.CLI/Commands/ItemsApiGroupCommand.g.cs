#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class ItemsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"items", @"Items endpoint commands.");
                         command.Subcommands.Add(ItemsWebsetsItemsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ItemsWebsetsItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ItemsWebsetsItemsListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}