namespace calculator.state_machine.result_str.states;

public class NegativeState : ResultStrState
{

    public NegativeState(string resultStr, StateMachine stateMachine) : base(
        resultStr, stateMachine)
    {
    }
    

    public override void ApplyZeroAction()
    {
        AppendAndChangeToNegativeState("0");
    }

    public override void ApplyNumberAction(int num)
    {
        AppendAndChangeToNegativeState($"{num}");
    }

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