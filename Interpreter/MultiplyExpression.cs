namespace Interpreter;
public class MultiplyExpression : Expression
{
    private readonly Expression _left, _right;
    public MultiplyExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret()
    {
        return _left.Interpret() * _right.Interpret();
    }

}
