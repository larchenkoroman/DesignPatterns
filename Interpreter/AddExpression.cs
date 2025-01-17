namespace Interpreter;
public class AddExpression : Expression
{
    private readonly Expression _left, _right;
    public AddExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret()
    {
        return _left.Interpret() + _right.Interpret();
    }
}
