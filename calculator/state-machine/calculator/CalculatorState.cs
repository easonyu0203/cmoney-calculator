namespace calculator.state_machine.calculator;

public abstract class CalculatorState : State
{
    public CalculatorData CalculatorData { get; }
    
    protected CalculatorState(CalculatorData calculatorData, StateMachine stateMachine): base(stateMachine)
    {
        CalculatorData = calculatorData;
    }
}