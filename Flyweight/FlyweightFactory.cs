namespace Flyweight;
using Key = string;
public class FlyweightFactory
{
    private readonly Dictionary<Key, IFlyweight> _flyweights = [];
    public IFlyweight GetFlyweight(Key key)
    {
        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new ConcreteFlyweight(key);
        }
        return _flyweights[key];
    }

    public int Length
    {
        get => _flyweights.Count;
    }
}
