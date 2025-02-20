
namespace TemplateMethodFileParser;

public abstract class FileParser
{
    public Dictionary<string, string> ParseFile(string fileName)
    {
        LogOperation($"Validating the file {fileName}");
        ValidateFile(fileName);

        LogOperation("Loading the file");
        string content = File.ReadAllText(fileName);

        LogOperation("Parsing the file");
        Dictionary<string, string> data = ParseContent(content);

        LogOperation("Validating data");
        ValidateData(data);

        LogOperation("Enriching data");
        EnrichData(data);

        return data;
    }

    protected virtual void EnrichData(Dictionary<string, string> data)
    {
        data["parsedAt"] = DateTime.UtcNow.ToString();
    }

    protected virtual void ValidateData(Dictionary<string, string> data)
    {
    }

    public virtual void LogOperation(string message) 
    {
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: {message}");
    }

    public abstract Dictionary<string, string> ParseContent(string content);

    private void ValidateFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException($"File {fileName} does not exists");
        }

        if(new FileInfo(fileName).Length == 0)
        {
            throw new Exception($"File {fileName} is empty");
        }
    }
}
