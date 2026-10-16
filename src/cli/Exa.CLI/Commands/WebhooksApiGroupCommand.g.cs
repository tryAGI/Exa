#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebhooksApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"webhooks", @"Webhooks endpoint commands.");
                         command.Subcommands.Add(WebhooksWebhooksCreateCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksListCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksUpdateCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}