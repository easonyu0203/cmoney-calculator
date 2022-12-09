using calculator.EquationSystem;

namespace calculator.state_machine.equation.states;

public class ConstructNumberState: EquationState
{
    private EquationStateMachine _equationStateMachine;
    
    public ConstructNumberState(EquationStateMachine stateMachine) : base(stateMachine)
    {
        _equationStateMachine = stateMachine;
    }

    public override void OnStateLeave()
    {
        _equationStateMachine.Equation.AddOperand(new Operand(_equationStateMachine.ResultValue));
    }


    // TODO: What should this do?
    public override void ApplySqrtAction()
    {
    }

    /// <summary>
    /// change to construct operand state
    /// </summary>
    public override void ApplyMultiplyAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyMultiplyAction();
    }

    public override void ApplyDivideAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyDivideAction();;
    }

    public override void ApplyPlusAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyPlusAction();;
    }

    public override void ApplyMinusAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyMinusAction();
    }
    
    /// <summary>
    /// add an operand to equation and calculate result
    /// </summary>
    /// <returns></returns>
    public override decimal ApplyEqualAction()
    {
        _equationStateMachine.Equation.AddOperand(new Operand(_equationStateMachine.ResultValue));
        decimal resultValue = _equationStateMachine.Equation.Calculate();
        _equationStateMachine.ChangeState(new AfterEqualState(_equationStateMachine));
        return resultValue;
    }
}