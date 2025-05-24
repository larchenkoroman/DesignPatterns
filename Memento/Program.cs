using Memento;

Originator originator = new Originator();
CareTaker careTaker = new CareTaker();

originator.SetState("State 1");
careTaker.AddMemento(originator.CreateMemento());
originator.SetState("State 2");
careTaker.AddMemento(originator.CreateMemento());
originator.SetState("State 3");
careTaker.AddMemento(originator.CreateMemento());
originator.SetState("State 4");

Console.WriteLine(originator.GetState());
originator.Restore(careTaker.GetMemento(1));
Console.WriteLine(originator.GetState());
