namespace calculator.state_machine.result_str.states;

public class InitState : ResultStrState
{
    public InitState(StateMachine stateMachine) : base("0", stateMachine)
    {
    }

    public override void ApplyZeroAction()
    {
    }

    public override void ApplyNumberAction(int num)
    {
        _stateMachine.ChangeState(new PositiveState($"{num}", _stateMachine));
    }

    public override void ApplyDecimalAction()
    {
        _stateMachine.ChangeState(new PositiveState("0.", _stateMachine));
    }

    public override void ApplyDeleteResultStrAction()
    {
    }

    public override void ApplyCleanResultStr()
    {
    }

    public override void ApplySignAction()
    {
    }

}