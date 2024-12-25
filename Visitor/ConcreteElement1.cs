using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor;

public class ConcreteElement1: IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation1()
    {
        return "Concrete element 1";
    }
}
