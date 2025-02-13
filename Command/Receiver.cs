﻿
namespace Command;

public class Receiver
{
    public void Action(string message) => Console.WriteLine($"Receiver invoked: {message}");
    public void UndoAction(string message) => Console.WriteLine($"Receiver undoing: {message}");
}