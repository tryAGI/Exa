#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class BatchesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"batches", @"Batches endpoint commands.");
                         command.Subcommands.Add(BatchesCancelBatchCommandApiCommand.Create());
                         command.Subcommands.Add(BatchesCreateBatchCommandApiCommand.Create());
                         command.Subcommands.Add(BatchesDeleteBatchCommandApiCommand.Create());
                         command.Subcommands.Add(BatchesGetBatchCommandApiCommand.Create());
                         command.Subcommands.Add(BatchesListBatchesCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}