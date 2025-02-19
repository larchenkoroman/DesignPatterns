namespace Decorator;

public class ConcreteDecorator1(IComponent component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("--------Concrete Decorator1-----------");
        _component.Operation();
        Console.WriteLine("--------Concrete Decorator1-----------");
    }
}
