namespace calculator.EquationSystem;

public class MinusOperator : BinaryOperator
{
    /// <summary>
    /// Minus
    /// </summary>
    /// <returns></returns>
    public override decimal Calculate()
    {
        decimal value = LeftOperand.Value - RightOperand.Value;
        return (value);
    }

    public override string ToString()
    {
        return "-";
    }
}