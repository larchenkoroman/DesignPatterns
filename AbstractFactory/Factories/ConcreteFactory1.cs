using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories;
public class ConcreteFactory1 : Factory
{
    public override IProduct1 CreateProduct1()
    {
        return new ConcreteProduct1();
    }
    public override IProduct2 CreateProduct2()
    {
        return new ConcreteProduct2();
    }
}
