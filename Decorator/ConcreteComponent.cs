﻿namespace Decorator;

public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Concrete component"); ;
    }
}
