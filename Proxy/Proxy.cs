namespace Proxy;

public class Proxy : ISubject
{
    private RealSubject? _realSubject = null;
    public Proxy()
    {
        Console.WriteLine("Instantiating proxy");
    }

    public void Operation()
    {
        Console.WriteLine("Perfoming operation in proxy");
        if( _realSubject is null)
        {
            Console.WriteLine("Real object is null. Creating it.");
            _realSubject = new RealSubject();
        }
        Console.WriteLine("Logging before operation");
        _realSubject.Operation();
        Console.WriteLine("Logging after operation");
    }
}
