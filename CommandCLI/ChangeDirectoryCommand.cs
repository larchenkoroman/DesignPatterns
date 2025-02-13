﻿namespace CommandCLI;

public class ChangeDirectoryCommand(FileSystemReceiver receiver) : ICommand
{
    private readonly FileSystemReceiver _receiver = receiver;
    public void Execute(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: cd <path>");
            return;
        }

        _receiver.ChangeDirectory(path: args[0]);
    }
}
