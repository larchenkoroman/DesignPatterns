
using System.Text.Json;

namespace TemplateMethodFileParser;

public class JsonParser : FileParser
{
    public override Dictionary<string, string> ParseContent(string content)
    {
        return JsonSerializer.Deserialize<Dictionary<string, string>>(content);
    }
}
