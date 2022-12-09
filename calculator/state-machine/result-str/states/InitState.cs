namespace calculator.state_machine.result_str.states;

public class InitState : ResultStrState
{
    public InitState(StateMachine stateMachine) : base("0", stateMachine)
    {
    }

    /// <summary>
    /// do nothing
    /// </summary>
    public override void ApplyZeroAction()
    {
    }

    /// <summary>
    /// change to positive number
    /// </summary>
    /// <param name="num">num</param>
    public override void ApplyNumberAction(int num)
    {
        _stateMachine.ChangeState(new PositiveState($"{num}", _stateMachine));
    }

    /// <summary>
    /// change to positive with 0.1
    /// </summary>
    public override void ApplyDecimalAction()
    {
        _stateMachine.ChangeState(new PositiveState("0.", _stateMachine));
    }

    /// <summary>
    /// do nothing
    /// </summary>
    public override void ApplyDeleteResultStrAction()
    {
    }
    
    /// <summary>
    /// do nothing
    /// </summary>
    public override void ApplySignAction()
    {
    }

}