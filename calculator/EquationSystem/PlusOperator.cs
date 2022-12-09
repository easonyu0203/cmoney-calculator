namespace calculator.EquationSystem;

public class PlusOperator : BinaryOperator
{
    public override decimal Calculate()
    {
        decimal value = LeftUnaryExpression.Value + RightUnaryExpression.Value;
        return (value);
    }

    public override string ToString()
    {
        return "+";
    }
}