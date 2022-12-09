namespace calculator.EquationSystem;

/// <summary>
/// unary operator
/// </summary>
public abstract class UnaryOperator
{
    public abstract decimal Calculate(decimal number);
    public override string ToString()
    {
        return "[null unary operator]";
    }
}

/// <summary>
/// sqrt operator
/// </summary>
public class SqrtOperator : UnaryOperator
{
    
    public override decimal Calculate(decimal number)
    {
        return (decimal)Math.Sqrt((double)number);
    }
    
    public override string ToString()
    {
        return "sqrt";
    }

}