using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor visitor);
}
