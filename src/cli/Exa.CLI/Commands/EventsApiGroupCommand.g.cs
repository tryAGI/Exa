#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class EventsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"events", @"Events endpoint commands.");
                         command.Subcommands.Add(EventsEventsGetCommandApiCommand.Create());
                         command.Subcommands.Add(EventsEventsListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}