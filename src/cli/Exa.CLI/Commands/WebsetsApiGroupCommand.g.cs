#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebsetsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"websets", @"Websets endpoint commands.");
                         command.Subcommands.Add(WebsetsWebsetsCancelCommandApiCommand.Create());
                         command.Subcommands.Add(WebsetsWebsetsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(WebsetsWebsetsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(WebsetsWebsetsGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebsetsWebsetsListCommandApiCommand.Create());
                         command.Subcommands.Add(WebsetsWebsetsUpdateCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}