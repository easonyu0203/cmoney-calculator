namespace calculator.EquationSystem;

public class Operand: ILinkable
{
    public readonly decimal Value;
    public BinaryOperator? LeftBinaryOperator { get; private set; }
    public BinaryOperator? RightBinaryOperator { get; private set; }

    public Operand(decimal value)
    {
        Value = value;
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
        return $"{Value}";
    }
}