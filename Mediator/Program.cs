using Mediator;

Colleague1 colleague1 = new Colleague1();
Colleague2 colleague2 = new Colleague2();
ConcreteMediator concreteMediator = new(colleague1, colleague2);

colleague1.Operation1();
colleague2.Operation2();