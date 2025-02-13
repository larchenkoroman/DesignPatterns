using CommandCLI;

CLI cli = new();
FileSystemReceiver fs = new FileSystemReceiver();
cli.RegisterCommand("ls", new ListCommand(fs));
cli.RegisterCommand("cd", new ChangeDirectoryCommand(fs));
cli.RegisterCommand("mkdir", new MakeDirectoryCommand(fs));

cli.EcecuteCommand(commandName: "mkdir", args: ["foo"]);
cli.EcecuteCommand(commandName: "ls", args: []);
cli.EcecuteCommand(commandName: "cd", args: ["foo"]);
cli.EcecuteCommand(commandName: "mkdir", args: ["foo2"]);
cli.EcecuteCommand(commandName: "ls", args: []);
cli.EcecuteCommand(commandName: "cd", args: [".."]);
cli.EcecuteCommand(commandName: "ls", args: []);
cli.EcecuteCommand(commandName: "123", args: ["foo"]);