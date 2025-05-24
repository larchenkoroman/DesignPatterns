namespace ChainOfResponsibility;

public class ConcreteHandler3 : Handler
{
    public override void Handle(string request)
    {
        if (request == "3")
        {
            Console.WriteLine("ConcreteHandler3 handled request 3");
            return;
        }

        if (_successor == null)
        {
            return;
        }

        _successor.Handle(request);
    }
}
