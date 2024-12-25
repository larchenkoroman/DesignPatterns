using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public interface IDocumentVisitor
{
    void Visit(TitleElement element);
    void Visit(SubtitleElement element);
    void Visit(ContentElement element);
}
