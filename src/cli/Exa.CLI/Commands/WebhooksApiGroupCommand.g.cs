#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class WebhooksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"webhooks", @"Webhooks endpoint commands.");
                         command.Subcommands.Add(WebhooksWebhooksCreateCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksListCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksUpdateCommandApiCommand.Create());
        return command;
    }
}