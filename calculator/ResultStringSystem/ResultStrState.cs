using calculator.state_machine;
using calculator.StateDesign;

namespace calculator.ResultStringSystem;

/// <summary>
/// base state for result string state machine
/// </summary>
/// 
/// <summary>
/// apply zero action
/// </summary>
public abstract class ResultStrState : State
{
    /// <summary>
    /// result string of the state
    /// </summary>
    public readonly string ResultStr;

    protected ResultStrState(string resultStr, StateMachine stateMachine) : base(stateMachine)
    {
        ResultStr = resultStr;
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public abstract void ApplyZeroAction();

    /// <summary>
    /// apply zero action
    /// </summary>
    public abstract void ApplyNumberAction(int num);

    /// <summary>
    /// apply zero action
    /// </summary>
    public abstract void ApplyDecimalAction();

    /// <summary>
    /// apply zero action
    /// </summary>
    public abstract void ApplySignAction();

    /// <summary>
    /// apply zero action
    /// </summary>
    public abstract void ApplySqrtAction();

    /// <summary>
    /// apply zero action
    /// </summary>
    public abstract void ApplyDeleteResultStrAction();
}