namespace Mediator;

public class Colleague1 : Colleague
{
    public void Operation1()
    {
        Console.WriteLine("Colleague1 does Operation1");
        _mediator.Notify(this, "Colleague1 did Operation1");
    }
    public void Receive(string @event)
    {
        Console.WriteLine($"Colleague1 received '{@event}'");
    }
}
