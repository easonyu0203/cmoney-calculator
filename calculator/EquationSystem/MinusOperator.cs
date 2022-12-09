namespace calculator.EquationSystem;

public class MinusOperator : BinaryOperator
{
    /// <summary>
    /// Minus
    /// </summary>
    /// <returns></returns>
    public override decimal Calculate()
    {
        decimal value = LeftUnaryExpression.Value - RightUnaryExpression.Value;
        return (value);
    }

    public override string ToString()
    {
        return "-";
    }
}