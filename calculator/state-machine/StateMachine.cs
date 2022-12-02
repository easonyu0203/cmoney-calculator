namespace calculator.state_machine;

public abstract class StateMachine
{
    /// <summary>
    /// invoke after state change
    /// </summary>
    public event Action<State>? StateChangedEvent;
    /// <summary>
    /// current state of state machine
    /// </summary>
    public State CurrentState { get; protected set; }

    public StateMachine()
    {
        CurrentState = null!;
    }

    /// <summary>
    /// init state machine, this should be call just after instantiate state machine 
    /// </summary>
    public void Init()
    {
        CurrentState = GetInitState();
        ChangeState(CurrentState);
    }

    /// <summary>
    /// change current state
    /// </summary>
    /// <param name="newState"></param>
    public void ChangeState(State newState)
    {
        CurrentState = newState;
        StateChangedEvent?.Invoke(CurrentState);
    }

    protected abstract State GetInitState();
}