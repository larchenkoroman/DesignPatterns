using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public class TitleElement : IDocumentElement
{
    public string Text { get; set; } = "";
    
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}
