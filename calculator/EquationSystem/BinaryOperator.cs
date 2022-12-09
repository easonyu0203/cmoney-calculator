namespace calculator.EquationSystem;

public abstract class BinaryOperator: ILinkable
{
    public Operand LeftOperand { get; private set; }
    public Operand RightOperand { get; private set; }

    public BinaryOperator()
    {
        LeftOperand = null!;
        RightOperand = null!;
    }

    public abstract decimal Calculate();

    public void SetLeft(ILinkable operand)
    {
        LeftOperand = (Operand)operand;
    }

    public void SetRight(ILinkable operand)
    {
        RightOperand = (Operand)operand;
    }

    public override string ToString()
    {
        return "[null operator]";
    }
}

public interface ILinkable
{
    public void SetLeft(ILinkable linkable);
    public void SetRight(ILinkable linkable);
}