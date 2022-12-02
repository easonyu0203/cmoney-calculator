namespace calculator.state_machine.expression;

public class ExpressionStateMachine : StateMachine
{
    public string EquationStr { get; private set; }

    public ExpressionStateMachine()
    {
        EquationStr = string.Empty;
    }
    
    protected override State GetInitState()
    {
    }

    public void ApplyNumberAction(decimal number)
    {
    }

    public void ApplyMultiplyAction()
    {
    }

    public void ApplyDivideAction()
    {
    }

    public void ApplyPlusAction()
    {
    }

    public void ApplyMinusAction()
    {
    }
}