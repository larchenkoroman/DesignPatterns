namespace Observer;

public class ConcreteSubject : ISubject
{
    private readonly List<IObserver> _observers = [];
    private string _state = "";
    public string GetState() => _state;
    public void Setstate(string state) 
    { 
        _state = state;
        this.Notify();
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        { 
            observer.Update();
        }
    }
}
