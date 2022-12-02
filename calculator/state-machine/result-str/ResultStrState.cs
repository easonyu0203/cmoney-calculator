namespace calculator.state_machine.result_str;

public abstract class ResultStrState : State
{
    public readonly string ResultStr;
    
    protected ResultStrState(string resultStr, StateMachine stateMachine): base(stateMachine)
    {
        ResultStr = resultStr;
    }
    
    public abstract void ApplyZeroAction();

    public abstract void ApplyNumberAction(int num);

    public abstract void ApplyDecimalAction();

    public abstract void ApplyDeleteResultStrAction();

    public abstract void ApplyCleanResultStr();

    public abstract void ApplySignAction();


}