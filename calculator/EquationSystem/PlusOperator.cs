namespace calculator.EquationSystem;

public class PlusOperator : BinaryOperator
{
    public override decimal Calculate()
    {
        decimal value = LeftOperand.Value + RightOperand.Value;
        return (value);
    }

    public override string ToString()
    {
        return "+";
    }
}