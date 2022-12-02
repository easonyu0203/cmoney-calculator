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

    public override void ApplyCleanResultStr()
    {
        _stateMachine.ChangeState(new InitState(_stateMachine));
    }

    /// <summary>
    /// remove - and to positive state
    /// </summary>
    public override void ApplySignAction()
    {
        _stateMachine.ChangeState(new PositiveState(ResultStr.Substring(1), _stateMachine));
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