using State;

Context context = new Context(new ConcreteStateA());

context.Request(); //State A
context.Request(); //State B
context.Request(); //State C
context.Request(); //State A