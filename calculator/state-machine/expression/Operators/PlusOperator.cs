namespace calculator.state_machine.expression.Operators;

public interface IOperator
{
    
}

public class PlusOperator: IOperator
{
    public override string ToString()
    {
        return "+";
    }
}

public class MultiplyOperator: IOperator
{
    public override string ToString()
    {
        return "x";
    }
}

public class Operand
{
    public int SqrtCnt = 0;
    public decimal Value = 0;

    public Operand(decimal value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value}";
    }
}