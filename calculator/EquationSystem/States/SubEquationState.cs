using calculator.EquationSystem.Elements;
using calculator.state_machine;
using calculator.StateDesign;

namespace calculator.EquationSystem.States;

/// <summary>
/// base state for sub equation state machine
/// </summary>
public abstract class SubEquationState : State
{
    /// <summary>
    /// reference of sub equation state machine
    /// </summary>
    protected SubEquationStateMachine SubEquationStateMachine;

    public SubEquationState(SubEquationStateMachine stateMachine) : base(stateMachine)
    {
        SubEquationStateMachine = stateMachine;
    }

    /// <summary>
    /// when add low operator
    /// </summary>
    /// <param name="lowOperator">operator</param>
    public abstract void AddLowOperator(Node lowOperator);

    /// <summary>
    /// when add high operator
    /// </summary>
    /// <param name="highOperator">operator</param>
    public abstract void AddHighOperator(Node highOperator);
}