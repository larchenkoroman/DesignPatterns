using AbstractFactory.Products;

namespace AbstractFactory.Factories;
public abstract class Factory
{
    public abstract IProduct1 CreateProduct1();
    public abstract IProduct2 CreateProduct2();
}
