#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class SearchesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"searches", @"Searches endpoint commands.");
                         command.Subcommands.Add(SearchesWebsetsSearchesCancelCommandApiCommand.Create());
                         command.Subcommands.Add(SearchesWebsetsSearchesCreateCommandApiCommand.Create());
                         command.Subcommands.Add(SearchesWebsetsSearchesGetCommandApiCommand.Create());
        return command;
    }
}