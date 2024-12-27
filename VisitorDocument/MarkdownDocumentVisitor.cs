using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public class MarkdownDocumentVisitor : Visitor
{
    public void VisitTitleElement(TitleElement element)
    {
        Console.WriteLine($"# {element.Text}");
    }

    public void VisitSubtitleElement(SubtitleElement element)
    {
        Console.WriteLine($"## {element.Text}");
    }

    public void VisitContentElement(ContentElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine();
    }
}
