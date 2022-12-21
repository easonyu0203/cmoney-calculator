using calculator.ResultStringSystem.states;
using calculator.state_machine;
using calculator.StateDesign;

namespace calculator.ResultStringSystem;

/// <summary>
/// result string state machine, handle result string action
/// </summary>
public class ResultStrStateMachine : StateMachine
{
    /// <summary>
    /// result string of the state machine
    /// </summary>
    public string ResultStr { get; private set; }

    /// <summary>
    /// stack of history state
    /// </summary>
    public readonly Stack<ResultStrState> HistoryStack;

    /// <summary>
    /// current result state
    /// </summary>
    private ResultStrState CurrenResultSTrtState => (ResultStrState)CurrentState;

    public ResultStrStateMachine(string placeHolder)
    {
        ResultStr = placeHolder;
        HistoryStack = new Stack<ResultStrState>();

        // save state to history
        StateChangedEvent += (newState) => { HistoryStack.Push((ResultStrState)newState); };
    }

    /// <summary>
    /// to previous state
    /// </summary>
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

    /// <summary>
    /// get init state
    /// </summary>
    /// <returns>init state</returns>
    protected override State GetInitState()
    {
        return new InitState(this);
    }

    // number manipulation action
    /// <summary>
    /// apply zero action
    /// </summary>
    public void ApplyZeroAction()
    {
        CurrenResultSTrtState.ApplyZeroAction();
        StateSync();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public void ApplyNumberAction(int num)
    {
        CurrenResultSTrtState.ApplyNumberAction(num);
        StateSync();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public void ApplyDecimalAction()
    {
        CurrenResultSTrtState.ApplyDecimalAction();
        StateSync();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public void ApplyDeleteResultStrAction()
    {
        CurrenResultSTrtState.ApplyDeleteResultStrAction();
        StateSync();
    }

    /// <summary>
    /// apply zero action
    /// </summary>// operator action
    public void ApplySignAction()
    {
        CurrenResultSTrtState.ApplySignAction();
        StateSync();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
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