namespace calculator.EquationSystem;

public class DivideOperator : BinaryOperator
{
    /// <summary>
    /// Divide
    /// </summary>
    /// <returns></returns>
    public override decimal Calculate()
    {
        decimal value = LeftOperand.Value / RightOperand.Value;
        return value;
    }

    public override string ToString()
    {
        return "/";
    }
}