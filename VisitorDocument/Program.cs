

using System.Linq.Expressions;

List<IDocumentElement> elements =
    [
        new TitleElement("The Visitor design pattern"),
        new SubtitleElement("Intent"),
        new ContentElement("Тут идет описание паттерна"),
        new SubtitleElement("Is it amazing"),
        new ContentElement("Yes!")
    ];

Console.WriteLine("Text format:");
TextDocumentVisitor textDocumentVisitor = new();

foreach(var element in elements)
{
    element.Accept(textDocumentVisitor);
}

Console.WriteLine("Markdown format:");
MarkdownDocumentVisitor markdownDocumentVisitor = new();

foreach(var element in elements)
{
    element.Accept(markdownDocumentVisitor);
}
