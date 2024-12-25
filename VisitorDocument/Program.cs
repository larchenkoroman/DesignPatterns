using VisitorDocument;

using System.Linq.Expressions;

List<IDocumentElement> elements = new();

elements.Add(new TitleElement() { Text = "The Visitor design pattern" });
elements.Add(new SubtitleElement() { Text = "Intent" });
elements.Add(new ContentElement() { Text = "Тут идет описание паттерна" });
elements.Add(new SubtitleElement() { Text = "Is it amazing?" });
elements.Add(new ContentElement() { Text = "Yes!" });

Console.WriteLine("Text format:");
TextDocumentVisitor textDocumentVisitor = new();

foreach(var element in elements)
{
    element.Accept(textDocumentVisitor);
}

Console.WriteLine("\n\nMarkdown format:");
MarkdownDocumentVisitor markdownDocumentVisitor = new();

foreach(var element in elements)
{
    element.Accept(markdownDocumentVisitor);
}

Console.ReadKey();