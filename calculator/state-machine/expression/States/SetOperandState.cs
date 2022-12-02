using calculator.state_machine.expression.Operators;

namespace calculator.state_machine.expression.States;

public class SetOperandState: ExpressionState
{
    public SetOperandState(StateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void ApplyNumberAction(decimal number)
    {
        _expressionStateMachine.Operands[^1] = new Operand(number);
    }

    public override void ApplySqrtAction()
    {
        
    }

    public override void ApplyMultiplyAction()
    {
        _expressionStateMachine.Operators.Add(new MultiplyOperator());
        _expressionStateMachine.ChangeState(new SetOperatorState(_expressionStateMachine));
    }

    public override void ApplyDivideAction()
    {
        
    }

    public override void ApplyPlusAction()
    {
        _expressionStateMachine.Operators.Add(new PlusOperator());
        _expressionStateMachine.ChangeState(new SetOperatorState(_expressionStateMachine));
    }

    public override void ApplyMinusAction()
    {
        
    }
}