using Observer;

ConcreteSubject subject = new();
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));

subject.Setstate("State 1");
Console.WriteLine();
subject.Setstate("State 2");
