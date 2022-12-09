namespace calculator.EquationSystem;

public class MultiplyOperator : BinaryOperator
{
    /// <summary>
    /// multiply
    /// </summary>
    /// <returns></returns>
    public override decimal Calculate()
    {
        decimal value = LeftOperand.Value * RightOperand.Value;
        return (value);
    }

    public override string ToString()
    {
        return "x";
    }
}