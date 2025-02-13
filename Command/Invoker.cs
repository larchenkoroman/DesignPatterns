namespace Command;

public class Invoker
{
    private readonly List<ICommand> _commands = [];
    private readonly Stack<ICommand> _undoStack = [];

    public void AddCommand(ICommand command) => _commands.Add(command);
    public void ExecuteAll() 
    {
        foreach (var command in _commands)
        {
            command.Execute();
            _undoStack.Push(command);
        }
    }

    public void UndoLastCommand()
    {
        _undoStack.TryPop(out ICommand command);
        command?.Undo();
    }
}
