namespace InterpreterSearchQueryLanguage;
public class NotWordExpression : Expression
{
    private readonly string _word;
    public NotWordExpression(string word) => _word = word;
    public override List<string> Interpret(List<string> words)
    {
        return words.Where(word => !word.Equals(_word, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
