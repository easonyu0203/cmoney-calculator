using System.Text;

namespace calculator.EquationSystem;

public class UnaryExpression: ILinkable
{
    /// <summary>
    /// the value effect by unary operator
    /// </summary>
    public decimal Value
    {
        get
        {
            decimal outputValue = RawNumber;
            foreach (UnaryOperator unaryOperator in UnaryOperators)
            {
                outputValue = unaryOperator.Calculate(outputValue);
            }
            return outputValue;
        }
    }

    public BinaryOperator? LeftBinaryOperator { get; private set; }
    public BinaryOperator? RightBinaryOperator { get; private set; }
    public List<UnaryOperator> UnaryOperators { get; }

    public decimal RawNumber { get; set; }

    public UnaryExpression(decimal value)
    {
        RawNumber = value;
        UnaryOperators = new List<UnaryOperator>();
    }

    public void SetLeft(ILinkable binaryOperator)
    {
        LeftBinaryOperator = (BinaryOperator)binaryOperator ;
    }

    public void SetRight(ILinkable binaryOperator)
    {
        RightBinaryOperator = (BinaryOperator)binaryOperator ;
    }
    
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (UnaryOperator unaryOperator in UnaryOperators)
        {
            stringBuilder.Append($"{unaryOperator}(");
        }
        stringBuilder.Append($"{RawNumber}");
        foreach (UnaryOperator unaryOperator in UnaryOperators)
        {
            stringBuilder.Append(")");
        }
        return stringBuilder.ToString();
    }
}