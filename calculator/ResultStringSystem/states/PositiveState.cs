using calculator.state_machine;

namespace calculator.ResultStringSystem.states;

/// <summary>
/// state enter when result value is negative
/// </summary>
public class PositiveState : ResultStrState
{
    public PositiveState(string resultStr, StateMachine stateMachine) : base(
        resultStr, stateMachine)
    {
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyZeroAction()
    {
        AppendAndChangeToPositiveState("0");
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyNumberAction(int num)
    {
        AppendAndChangeToPositiveState($"{num}");
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyDecimalAction()
    {
        AppendAndChangeToPositiveState(".");
    }

    /// <summary>
    /// to previous result str state
    /// </summary>
    public override void ApplyDeleteResultStrAction()
    {
        ((ResultStrStateMachine)_stateMachine).ToPreviousState();
    }

    /// <summary>
    /// prefix - and change to negative state
    /// </summary>
    public override void ApplySignAction()
    {
        _stateMachine.ChangeState(new NegativeState($"-{ResultStr}", _stateMachine));
    }

    /// <summary>
    /// perform sqrt action
    /// </summary>
    public override void ApplySqrtAction()
    {
        decimal value = decimal.Parse(ResultStr);
        value = (decimal)Math.Sqrt((double)value);
        _stateMachine.ChangeState(
            new PositiveState($"{value}", _stateMachine)
        );
    }

    /// <summary>
    /// append str to result and change to positive state
    /// </summary>
    /// <param name="appendStr">string to append</param>
    private void AppendAndChangeToPositiveState(string appendStr)
    {
        string newResultStr = ResultStr + appendStr;
        _stateMachine.ChangeState(
            new PositiveState(newResultStr, _stateMachine)
        );
    }
}