using calculator.state_machine;

namespace calculator.StateDesign;

/// <summary>
/// base state for state machine
/// </summary>
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