using calculator.EquationSystem.Elements;

namespace calculator.EquationSystem.States;

/// <summary>
/// after add low operator
/// </summary>
public class AfterLowOperatorState : SubEquationState
{
    public AfterLowOperatorState(SubEquationStateMachine stateMachine) : base(stateMachine)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddLowOperator(Node lowOperator)
    {
        SubEquationStateMachine.CombineLastOperator();

        SubEquationStateMachine.OperatorStack.Push(lowOperator);
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