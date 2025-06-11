using Bridge.Implementors;

namespace Bridge.Abstractions;

public abstract class Abstraction(IImplementor implementor)
{
    protected IImplementor Implementor { get; init; } = implementor;

    public abstract void Foo();
}
