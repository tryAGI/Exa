#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class MonitorsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"monitors", @"Monitors endpoint commands.");
                         command.Subcommands.Add(MonitorsBatchMonitorsCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsCreateMonitorCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsDeleteMonitorCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsGetMonitorCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsListMonitorsCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsMonitorsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsMonitorsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsMonitorsGetCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsMonitorsListCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsMonitorsUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsTriggerMonitorCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsUpdateMonitorCommandApiCommand.Create());
        return command;
    }
}