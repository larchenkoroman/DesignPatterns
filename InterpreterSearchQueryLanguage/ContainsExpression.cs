namespace InterpreterSearchQueryLanguage;
public class ContainsExpression : Expression
{
    private readonly string _str;
    public ContainsExpression(string str) => _str = str;
    public override List<string> Interpret(List<string> words)
    {
        return words.Where(word => word.Contains(_str, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
