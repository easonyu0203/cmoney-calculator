using calculator.EquationSystem.Elements;

namespace calculator.EquationSystem;

/// <summary>
/// operator is binary operator
/// </summary>
public class PlusOperator : Node
{
    public override decimal CalculateValue()
    {
        return Left!.CalculateValue() + Right!.CalculateValue();
    }

    public override string ToString()
    {
        return "+";
    }
}