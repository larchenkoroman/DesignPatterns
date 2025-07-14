namespace Proxy;

public class RealSubject : ISubject
{
    public RealSubject()
    {
        Console.WriteLine("Instantiating real subject");
    }

    public void Operation()
    {
        Console.WriteLine("Perfoming operation in real subject");
    }
}
