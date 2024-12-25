using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor;

public class ConcreteElement2: IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    public string Operation2()
    {
        return "Concrete element 2";
    }
}
