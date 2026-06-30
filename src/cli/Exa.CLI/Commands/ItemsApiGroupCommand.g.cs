#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class ItemsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"items", @"Items endpoint commands.");
                         command.Subcommands.Add(ItemsWebsetsItemsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ItemsWebsetsItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ItemsWebsetsItemsListCommandApiCommand.Create());
        return command;
    }
}