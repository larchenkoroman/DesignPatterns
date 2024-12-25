using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public class TitleElement: IDocumentElement
{
    private string _text;

    TitleElement(string text) => _text = text;

    public string Text { get; } = "";
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}
