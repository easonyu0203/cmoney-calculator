namespace calculator.EquationSystem;

public class DivideOperator : BinaryOperator
{
    /// <summary>
    /// Divide
    /// </summary>
    /// <returns></returns>
    public override decimal Calculate()
    {
        decimal value = LeftUnaryExpression.Value / RightUnaryExpression.Value;
        return value;
    }

    public override string ToString()
    {
        return "/";
    }
}