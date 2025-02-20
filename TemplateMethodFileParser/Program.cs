using TemplateMethodFileParser;

FileParser csvParser = new CsvParser();
FileParser jsonParser = new JsonParser();

string curdir = Directory.GetCurrentDirectory();

var csvData = csvParser.ParseFile(Path.Join(curdir, "_files", "config.csv"));
Console.WriteLine("CSV data");
foreach (var pair in csvData)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

var jsonData = jsonParser.ParseFile(Path.Join(curdir, "_files", "config.json"));
Console.WriteLine("Json data");
foreach (var pair in jsonData)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}
