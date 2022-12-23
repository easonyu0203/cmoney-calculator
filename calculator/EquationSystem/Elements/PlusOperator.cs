namespace calculator.EquationSystem.Elements;

/// <summary>
/// operator is binary operator
/// </summary>
public class PlusOperator : Node
{
    /// <summary>
    /// calculate left + right 
    /// </summary>
    /// <returns>left + right </returns>
    public override decimal CalculateValue()
    {
        return Left!.CalculateValue() + Right!.CalculateValue();
    }

    public override string ToString()
    {
        return "+";
    }
}