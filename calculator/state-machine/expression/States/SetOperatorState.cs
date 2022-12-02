using calculator.state_machine.expression.Operators;

namespace calculator.state_machine.expression.States;

public class SetOperatorState: ExpressionState
{
    public SetOperatorState(StateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void ApplyNumberAction(decimal number)
    {
        _expressionStateMachine.Operands.Add(new Operand(number));
        _expressionStateMachine.ChangeState(new SetOperandState(_expressionStateMachine));
    }

    public override void ApplySqrtAction()
    {
        
    }

    public override void ApplyMultiplyAction()
    {
        _expressionStateMachine.Operators[^1] =new MultiplyOperator();
    }

    public override void ApplyDivideAction()
    {
        
    }

    public override void ApplyPlusAction()
    {
        _expressionStateMachine.Operators[^1]= new PlusOperator();
    }

    public override void ApplyMinusAction()
    {
        
    }
}