namespace TemplateMethod;

public class ConcreteClass2 : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("PrimitiveOperation1 called");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("PrimitiveOperation2 called");
    }

    public override void Hook()
    {
        Console.WriteLine("Hook called in concrete class");
    }
}
