﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor;

public interface IVisitor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}
