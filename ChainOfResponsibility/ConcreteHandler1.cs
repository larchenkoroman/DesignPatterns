namespace ChainOfResponsibility;

public class ConcreteHandler1 : Handler
{
    public override void Handle(string request)
    {
        if(request == "1")
        {
            Console.WriteLine("ConcreteHandler1 handled request 1");
            return;
        }

        if(_successor == null)
        {
            return;
        }

        _successor.Handle(request);
    }
}
