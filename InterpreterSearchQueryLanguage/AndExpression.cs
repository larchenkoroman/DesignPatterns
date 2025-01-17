namespace InterpreterSearchQueryLanguage;
public class AndExpression : Expression
{
    private readonly Expression _left, _right;
    public AndExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }
    public override List<string> Interpret(List<string> words)
    {
        return _left.Interpret(words)
                    .Intersect(_right.Interpret(words))
                    .ToList();
    }
}
