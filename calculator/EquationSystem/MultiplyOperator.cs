namespace calculator.EquationSystem;

public class MultiplyOperator : BinaryOperator
{
    /// <summary>
    /// multiply
    /// </summary>
    /// <returns></returns>
    public override decimal Calculate()
    {
        decimal value = LeftUnaryExpression.Value * RightUnaryExpression.Value;
        return (value);
    }

    public override string ToString()
    {
        return "x";
    }
}