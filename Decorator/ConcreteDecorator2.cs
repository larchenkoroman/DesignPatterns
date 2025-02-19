namespace Decorator;

public class ConcreteDecorator2(IComponent component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("--------Concrete Decorator2-----------");
        _component.Operation();
        Console.WriteLine("--------Concrete Decorator2-----------");
    }
}
