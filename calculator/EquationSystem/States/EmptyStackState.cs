using calculator.EquationSystem.Elements;
using calculator.EquationSystem.States;

namespace calculator.EquationSystem;

/// <summary>
/// state one first init, nothing in stack
/// </summary>
public class EmptyStackState : SubEquationState
{
    public EmptyStackState(SubEquationStateMachine stateMachine) : base(stateMachine)
    {
    }

    /// <summary>
    /// push one operator and to low operator state
    /// </summary>
    public override void AddLowOperator(Node lowOperator)
    {
        SubEquationStateMachine.OperatorStack.Push(lowOperator);
        SubEquationStateMachine.ChangeState(new AfterLowOperatorState(SubEquationStateMachine));
    }

    /// <summary>
    /// push one operator and to high operator state
    /// </summary>
    public override void AddHighOperator(Node highOperator)
    {
        SubEquationStateMachine.OperatorStack.Push(highOperator);
        SubEquationStateMachine.ChangeState(new AfterHighOperatorState(SubEquationStateMachine));
    }
}