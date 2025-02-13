﻿namespace Command;

public class ConcreteCommand(Receiver receiver, string message) : ICommand
{
    private readonly Receiver _receiver = receiver;
    private readonly string _message = message;
    public void Execute() => _receiver.Action(_message);
    public void Undo() => _receiver.UndoAction(_message);

}
