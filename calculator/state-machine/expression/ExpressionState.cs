namespace calculator.state_machine.expression;

public abstract class ExpressionState
{
    public abstract void ApplyNumberAction(decimal number);

    public abstract void ApplyMultiplyAction();

    public abstract void ApplyDivideAction();

    public abstract void ApplyPlusAction();

    public abstract void ApplyMinusAction();
}