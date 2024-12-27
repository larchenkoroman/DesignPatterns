using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDocument;

public class Visitor
{
    public void Visit(DocumentElement element)
    {
        var method = this.GetType().GetMethod("Visit" + element.GetType().Name);
        method?.Invoke(this, new[] { element });
    }
}
