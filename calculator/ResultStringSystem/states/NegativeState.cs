using calculator.state_machine;

namespace calculator.ResultStringSystem.states;

/// <summary>
/// state enter when result value is negative
/// </summary>
public class NegativeState : ResultStrState
{

    public NegativeState(string resultStr, StateMachine stateMachine) : base(
        resultStr, stateMachine)
    {
    }
    
    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyZeroAction()
    {
        AppendAndChangeToNegativeState("0");
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyNumberAction(int num)
    {
        AppendAndChangeToNegativeState($"{num}");
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyDecimalAction()
    {
        AppendAndChangeToNegativeState(".");
    }

    /// <summary>
    /// to previous result str state
    /// </summary>
    public override void ApplyDeleteResultStrAction()
    {
        ((ResultStrStateMachine)_stateMachine).ToPreviousState();
    }

    /// <summary>
    /// remove - and to positive state
    /// </summary>
    public override void ApplySignAction()
    {
        _stateMachine.ChangeState(new PositiveState(ResultStr.Substring(1), _stateMachine));
    }

    /// <summary>
    /// throw exception
    /// </summary>
    public override void ApplySqrtAction()
    {
        throw new Exception("cant sqrt negative number");
    }

    /// <summary>
    /// append str to result and change to negative state
    /// </summary>
    /// <param name="appendStr">string to append</param>
    private void AppendAndChangeToNegativeState(string appendStr)
    {
        string newResultStr = ResultStr + appendStr;
        _stateMachine.ChangeState(
            new NegativeState(newResultStr, _stateMachine)
        );
    }
}