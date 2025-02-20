using TemplateMethod;

AbstractClass instance = new ConcreteClass1();
instance.TemplateMethod();
Console.WriteLine();
AbstractClass instance2 = new ConcreteClass2();
instance2.TemplateMethod();