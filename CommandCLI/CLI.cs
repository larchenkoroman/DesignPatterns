namespace CommandCLI;

public class CLI
{
    private readonly Dictionary<string, ICommand> _commands = [];
    public void RegisterCommand(string commandName, ICommand command) => _commands[commandName] = command;
    public void EcecuteCommand(string commandName, string[] args)
    {
        var concatenatedArgs = string.Join(", ", args);
        Console.WriteLine($"$>{commandName} {concatenatedArgs}");

        if (!_commands.TryGetValue(commandName, out ICommand command))
        {
            Console.WriteLine($"The command {commandName} does not exists"); 
            return;
        }

        command.Execute(args);
    }
}
