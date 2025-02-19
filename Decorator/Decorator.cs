﻿namespace Decorator;

public abstract class Decorator(IComponent component) : IComponent
{
    protected IComponent _component = component;
    public virtual void Operation()
    {
        _component.Operation();
    }
}
