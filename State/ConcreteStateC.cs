namespace State;

public class ConcreteStateC : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateC handles the request");
        context.SetState(new ConcreteStateA());
    }
}
