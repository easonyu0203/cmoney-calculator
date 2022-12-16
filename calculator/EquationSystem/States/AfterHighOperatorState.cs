using calculator.EquationSystem.Elements;
using calculator.EquationSystem.States;

namespace calculator.EquationSystem;

public class AfterHighOperatorState : SubEquationState
{
    public AfterHighOperatorState(SubEquationStateMachine stateMachine) : base(stateMachine)
    {
    }

    /// <summary>
    /// after high operator, we can just pop all previous operator, and change to low state
    /// </summary>
    public override void AddLowOperator(Node lowOperator)
    {
        SubEquationStateMachine.CombineAllOperator();
        SubEquationStateMachine.OperatorStack.Push(lowOperator);
        SubEquationStateMachine.ChangeState(new AfterLowOperatorState(SubEquationStateMachine));
    }

    /// <summary>
    /// after high operator, we can just pop all previous operator
    /// </summary>
    public override void AddHighOperator(Node highOperator)
    {
        SubEquationStateMachine.CombineLastOperator();
        SubEquationStateMachine.OperatorStack.Push(highOperator);
    }
}