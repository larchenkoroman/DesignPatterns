using Command;

Receiver receiver = new Receiver();
Invoker invoker =  new Invoker();

invoker.AddCommand(new ConcreteCommand(receiver, message: "1"));
invoker.AddCommand(new ConcreteCommand(receiver, message: "2"));
invoker.AddCommand(new ConcreteCommand(receiver, message: "3"));
invoker.ExecuteAll();
invoker.UndoLastCommand();
invoker.UndoLastCommand();
invoker.UndoLastCommand();
invoker.UndoLastCommand();
