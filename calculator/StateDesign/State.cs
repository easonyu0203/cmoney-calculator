namespace calculator.state_machine;

public abstract class State
{
    /// <summary>
    /// reference of the state machine this state at
    /// </summary>
    protected StateMachine _stateMachine;

    protected State(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    
}