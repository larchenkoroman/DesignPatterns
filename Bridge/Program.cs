using Bridge;
using Bridge.Abstractions;
using Bridge.Implementors;

Abstraction abstraction = new RefinedAbstraction2(new ConcreteImplementor1());
abstraction.Foo();