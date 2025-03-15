namespace Composite;

public class Compozite : Component
{
    private readonly List<Component> _children = [];
    public override void Operation()
    {
        foreach(Component child in _children)
        {
            child.Operation();
        }
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override Component GetChild(int index)
    {
        return (index >= 0 && index < _children.Count) ? _children[index]: null;
    }
}
