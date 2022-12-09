namespace calculator.EquationSystem;

public abstract class BinaryOperator: ILinkable
{
    public UnaryExpression LeftUnaryExpression { get; private set; }
    public UnaryExpression RightUnaryExpression { get; private set; }

    public BinaryOperator()
    {
        LeftUnaryExpression = null!;
        RightUnaryExpression = null!;
    }

    public abstract decimal Calculate();

    public void SetLeft(ILinkable operand)
    {
        LeftUnaryExpression = (UnaryExpression)operand;
    }

    public void SetRight(ILinkable operand)
    {
        RightUnaryExpression = (UnaryExpression)operand;
    }

    public override string ToString()
    {
        return "[null operator]";
    }
}