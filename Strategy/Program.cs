using Strategy;

Context context =  new Context();

context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();