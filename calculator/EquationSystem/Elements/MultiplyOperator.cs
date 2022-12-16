namespace calculator.EquationSystem.Elements;

/// <summary>
/// operator is binary operator
/// </summary>
public class MultiplyOperator : Node
{
    public override decimal CalculateValue()
    {
        return Left!.CalculateValue() * Right!.CalculateValue();
    }

    public override string ToString()
    {
        return "x";
    }
}