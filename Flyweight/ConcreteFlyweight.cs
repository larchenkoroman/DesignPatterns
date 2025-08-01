namespace Flyweight;

public class ConcreteFlyweight(string intrinsicState) : IFlyweight
{
    private readonly string _intrinsicState = intrinsicState;
    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"CoccreteFlyweight. IntrinsicState({_intrinsicState}). Extrinsic state({extrinsicState})");
    }
}
