using calculator.state_machine.expression.Operators;

namespace calculator.state_machine.expression.States;

public class FirstSetOperandState: ExpressionState
{
    
    public FirstSetOperandState(StateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void ApplyNumberAction(decimal number)
    {
        _expressionStateMachine.Operands.Add(new Operand(number));
        _expressionStateMachine.ChangeState(new FirstSetOperatorState(_expressionStateMachine));
    }

    public override void ApplySqrtAction()
    {
        
    }

    public override void ApplyMultiplyAction()
    {
        _expressionStateMachine.Operands.Add(new Operand(0));
        _expressionStateMachine.Operators.Add(new MultiplyOperator());
        _expressionStateMachine.ChangeState(new SetOperandState(_expressionStateMachine));
    }

    public override void ApplyDivideAction()
    {
        
    }

    public override void ApplyPlusAction()
    {
        _expressionStateMachine.Operands.Add(new Operand(0));
        _expressionStateMachine.Operators.Add(new PlusOperator());
        _expressionStateMachine.ChangeState(new SetOperandState(_expressionStateMachine));
    }

    public override void ApplyMinusAction()
    {
        
    }

}