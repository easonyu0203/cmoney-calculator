namespace calculator.state_machine;

public abstract class State
{
    /// <summary>
    /// reference of the state machine this state at
    /// </summary>
    protected StateMachine _stateMachine;
    
    public State(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    //
    // public abstract void ApplyZeroAction();
    //
    // public abstract void ApplyNumberAction(int num);
    //
    // public abstract void ApplyDecimalAction();
    //
    // public abstract void ApplyDeleteResultStrAction();
    //
    // public abstract void ApplyCleanResultStr();
    //
    // public abstract void ApplySignAction();
    //
    // public abstract void ApplySqrtAction();
    //
    // public abstract void ApplyMultiplyAction();
    //
    // public abstract void ApplyDivideAction();
    //
    // public abstract void ApplyPlusAction();
    //
    // public abstract void ApplyMinusAction();
    //
    // public abstract void ApplyEqualAction();
    //
    // public abstract void ApplyCleanAll();
}