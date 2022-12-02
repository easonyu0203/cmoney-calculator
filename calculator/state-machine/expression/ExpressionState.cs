namespace calculator.state_machine.expression;

public abstract class ExpressionState : State
{
    protected ExpressionStateMachine _expressionStateMachine => (ExpressionStateMachine)_stateMachine;

    protected ExpressionState(StateMachine stateMachine) : base(stateMachine)
    {
    }
    public abstract void ApplyNumberAction(decimal number);

    public abstract void ApplySqrtAction();

    public abstract void ApplyMultiplyAction();

    public abstract void ApplyDivideAction();

    public abstract void ApplyPlusAction();

    public abstract void ApplyMinusAction();

 
}