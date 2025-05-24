namespace ChainOfResponsibility;

public class ConcreteHandler2 : Handler
{
    public override void Handle(string request)
    {
        if (request == "2")
        {
            Console.WriteLine("ConcreteHandler2 handled request 2");
            return;
        }

        if (_successor == null)
        {
            return;
        }

        _successor.Handle(request);
    }
}
