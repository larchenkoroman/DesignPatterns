using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public class ContentElement : IDocumentElement
{
    private string _text;

    ContentElement(string text) => _text = text;

    public string Text { get; } = "";
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}