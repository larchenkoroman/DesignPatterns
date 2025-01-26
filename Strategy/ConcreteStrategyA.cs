namespace Strategy;

public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing strategy A");
    }
}
