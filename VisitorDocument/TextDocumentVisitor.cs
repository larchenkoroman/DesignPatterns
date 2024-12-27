using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisitorDocument;

public class TextDocumentVisitor : Visitor
{
    public void VisitTitleElement(TitleElement element)
    {
        Console.WriteLine(element.Text.ToUpper());
        Console.WriteLine(new string('=', element.Text.Length));
        Console.WriteLine();
    }

    public void VisitSubtitleElement(SubtitleElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine(new string('-', element.Text.Length));
    }

    public void VisitContentElement(ContentElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine();
    }
}
