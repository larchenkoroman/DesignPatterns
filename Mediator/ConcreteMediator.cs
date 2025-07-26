namespace Mediator;

public class ConcreteMediator : IMediator
{
    private readonly Colleague1 colleague1;
    private readonly Colleague2 colleague2;

    public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
    {
        this.colleague1 = colleague1;
        this.colleague1.SetMediator(this);
        this.colleague2 = colleague2;
        this.colleague2.SetMediator(this);
    }

    public void Notify(Colleague sender, string @event)
    {
        Console.WriteLine($"Concrete mediator notified by {sender.GetType().Name}");
        if (sender == colleague1)
        {
            this.colleague2.Receive(@event);
        }
        else if (sender == colleague2) 
        {
            this.colleague1.Receive(@event);
        }
    }
}
