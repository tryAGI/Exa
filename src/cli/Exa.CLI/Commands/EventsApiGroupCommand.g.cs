#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class EventsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"events", @"Events endpoint commands.");
                         command.Subcommands.Add(EventsEventsGetCommandApiCommand.Create());
                         command.Subcommands.Add(EventsEventsListCommandApiCommand.Create());
        return command;
    }
}