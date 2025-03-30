namespace Iterator;

public class ConcreteIterator<T>(ConcreteAggregate<T> aggregate) : Iterator<T>
{
    private readonly ConcreteAggregate<T> _aggregate = aggregate;
    private int _currentIndex = -1;
    public bool HasNext()
    {
        return _currentIndex < _aggregate.Count - 1;
    }

    public T Next()
    {
        if (HasNext())
        {
            _currentIndex++;
            return _aggregate.GetItemAt(_currentIndex);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void Reset() => _currentIndex = -1;
}
