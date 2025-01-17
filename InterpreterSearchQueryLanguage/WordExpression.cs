namespace InterpreterSearchQueryLanguage;
public class WordExpression : Expression
{
    private readonly string _word;
    public WordExpression(string word) => _word = word;
    public override List<string> Interpret(List<string> words)
    {
        return words.Where(word => word.Equals(_word, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
