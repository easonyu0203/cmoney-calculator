using calculator.EquationSystem.Elements;
using calculator.state_machine;

namespace calculator.EquationSystem.States;

public abstract class SubEquationState : State
{
    protected SubEquationStateMachine SubEquationStateMachine;

    public SubEquationState(SubEquationStateMachine stateMachine) : base(stateMachine)
    {
        SubEquationStateMachine = stateMachine;
    }

    public abstract void AddLowOperator(Node lowOperator);

    public abstract void AddHighOperator(Node highOperator);
}