namespace TemplateMethod;

public class ConcreteClass1 : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("PrimitiveOperation1 invoked");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("PrimitiveOperation2 invoked");
    }
}
