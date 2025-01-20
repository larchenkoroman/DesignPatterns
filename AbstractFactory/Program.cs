using AbstractFactory.Factories;
using AbstractFactory.Products;

Factory factory = new ConcreteFactory1();
IProduct1 product1 = factory.CreateProduct1();
IProduct2 product2 = factory.CreateProduct2();

Console.WriteLine(product1.GetType().Name);