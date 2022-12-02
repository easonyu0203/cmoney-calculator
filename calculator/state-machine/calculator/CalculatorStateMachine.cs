using calculator.state_machine.calculator.states;

namespace calculator.state_machine.calculator;

public class CalculatorStateMachine: StateMachine
{
    public CalculatorData CalculatorData { get; private set; }

    public CalculatorStateMachine(CalculatorData calculatorData)
    {
        CalculatorData = calculatorData;
    }
    
    protected override State GetInitState()
    {
        return new ConstructResultStrState(CalculatorData,"0", this);
    }

    protected override void AfterApplyAction()
    {
        CalculatorState currentCalculatorState = (CalculatorState)CurrentState;
        CalculatorData = currentCalculatorState.CalculatorData;
    }
}