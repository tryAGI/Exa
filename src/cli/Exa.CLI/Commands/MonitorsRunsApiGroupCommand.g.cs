#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class MonitorsRunsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"monitors-runs", @"Monitors Runs endpoint commands.");
                         command.Subcommands.Add(MonitorsRunsMonitorsRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsRunsMonitorsRunsListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}