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

    /// <summary>
    /// reinit state machine 
    /// </summary>
    public void ReInit()
    {
        ResultStr = "[None]";
        HistoryStack.Clear();
        ChangeState(new InitState(this));
    }
    
    protected override State GetInitState()
    {
        return new InitState(this);
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

    // operator action
    public void ApplySignAction()
    {
        CurrenResultSTrtState.ApplySignAction();
        StateSync();
    }

    public void ApplySqrtAction()
    {
        CurrenResultSTrtState.ApplySqrtAction();
        StateSync();
    }

    /// <summary>
    /// update data after apply action, from state => state machine
    /// </summary>
    private void StateSync()
    {
        ResultStrState currentResultStrState = CurrenResultSTrtState;
        ResultStr = currentResultStrState.ResultStr;
    }

}