using calculator.EquationSystem;

namespace calculator.state_machine.equation.states;

public class AfterEqualState:EquationState
{
    private EquationStateMachine _equationStateMachine;
    
    public AfterEqualState(EquationStateMachine stateMachine) : base(stateMachine)
    {
        _equationStateMachine = stateMachine;
    }

    /// <summary>
    /// restart the equation
    /// </summary>
    public override void OnStateLeave()
    {
        _equationStateMachine.Equation = new Equation();
    }

    public override void ApplyZeroAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
    }

    public override void ApplyNumberAction(int num)
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplyNumberAction(num);
    }

    public override void ApplyDecimalAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplyDecimalAction();
    }

    public override void ApplySqrtAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplySqrtAction();
    }

    public override void ApplyMultiplyAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplyMultiplyAction();
    } 

    public override void ApplyDivideAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplyDivideAction();
    } 

    public override void ApplyPlusAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplyPlusAction();
    } 

    public override void ApplyMinusAction()
    {
        _equationStateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
        _equationStateMachine.ApplyMinusAction();
    } 
}