using calculator.state_machine.result_str.states;

namespace calculator.state_machine.result_str;

public class ResultStrStateMachine: StateMachine
{
    public string ResultStr { get; private set; }

    public readonly Stack<ResultStrState> HistoryStack;

    private ResultStrState CurrenResultSTrtState => (ResultStrState)CurrentState;

    public ResultStrStateMachine(string placeHolder)
    {
        ResultStr = placeHolder;
        HistoryStack = new Stack<ResultStrState>();
        
        // save state to history
        StateChangedEvent += (newState) =>
        {
            HistoryStack.Push((ResultStrState)newState);
        };
    }
    
    public void ToPreviousState()
    {
        HistoryStack.Pop();
        ResultStrState state = HistoryStack.Pop();
        ChangeState(state);
    }
    
    protected override State GetInitState()
    {
        return new InitState(this);
    }

    /// <summary>
    /// update data after apply action, from state => state machine
    /// </summary>
    protected void StateSync()
    {
        ResultStrState currentResultStrState = CurrenResultSTrtState;
        ResultStr = currentResultStrState.ResultStr;
    }

    
    // number manipulation action
    public void ApplyZeroAction()
    {
        CurrenResultSTrtState.ApplyZeroAction();
        StateSync();
    }

    public void ApplyNumberAction(int num)
    {
        CurrenResultSTrtState.ApplyNumberAction(num);
        StateSync();
    }

    public void ApplyDecimalAction()
    {
        CurrenResultSTrtState.ApplyDecimalAction();
        StateSync();
    }

    public void ApplyDeleteResultStrAction()
    {
        CurrenResultSTrtState.ApplyDeleteResultStrAction();
        StateSync();
    }

    public void ApplyCleanResultStr()
    {
        CurrenResultSTrtState.ApplyCleanResultStr();
        StateSync();
    }

    // operator action
    public void ApplySignAction()
    {
        CurrenResultSTrtState.ApplySignAction();
        StateSync();
    }

}