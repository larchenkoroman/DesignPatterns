﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public class MarkdownDocumentVisitor: IDocumentVisitor
{
    public void Visit(TitleElement element)
    {
        Console.WriteLine($"# {element.Text}");
    }
    public void Visit(SubtitleElement element)
    {
        Console.WriteLine($"## {element.Text}");
    }
    public void Visit(ContentElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine();
    }
}
