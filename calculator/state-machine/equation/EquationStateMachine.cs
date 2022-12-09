using calculator.EquationSystem;
using calculator.state_machine.equation;
using calculator.state_machine.equation.states;

namespace calculator.state_machine;

public class EquationStateMachine : StateMachine
{
    /// <summary>
    /// current result string in calculator
    /// </summary>
    public decimal ResultValue => Calculator.ResultValue;
    /// <summary>
    /// reference of Calculator
    /// </summary>
    public readonly ICalculator Calculator;

    /// <summary>
    /// equation object
    /// </summary>
    public Equation Equation;
    
    private EquationState CurrentEquationState => (EquationState)CurrentState;

    public EquationStateMachine(ICalculator calculator)
    {
        Calculator = calculator;
        Equation = new Equation();
    }

    /// <summary>
    /// init state should be construct number
    /// </summary>
    /// <returns></returns>
    protected override State GetInitState()
    {
        return new ConstructNumberState(this);
    }

    // number manipulation action
    public void ApplyZeroAction()
    {
        CurrentEquationState.ApplyZeroAction();
    }

    public void ApplyNumberAction(int num)
    {
        CurrentEquationState.ApplyNumberAction(num);
    }

    public void ApplyDecimalAction()
    {
        CurrentEquationState.ApplyDecimalAction();
    }

    public void ApplyDeleteResultStrAction()
    {
        CurrentEquationState.ApplyDeleteResultStrAction();
    }

    public void ApplyCleanResultStr()
    {
        CurrentEquationState.ApplyCleanResultStr();
    }

    // operator action
    public void ApplySignAction()
    {
        CurrentEquationState.ApplySignAction();
    }

    public decimal ApplySqrtAction()
    {
        return CurrentEquationState.ApplySqrtAction();
    }

    public void ApplyMultiplyAction()
    {
        CurrentEquationState.ApplyMultiplyAction();
    }

    public void ApplyDivideAction()
    {
        CurrentEquationState.ApplyDivideAction();
    }

    public void ApplyPlusAction()
    {
        CurrentEquationState.ApplyPlusAction();
    }

    public void ApplyMinusAction()
    {
        CurrentEquationState.ApplyMinusAction();
    }

    public decimal ApplyEqualAction()
    {
        return CurrentEquationState.ApplyEqualAction();
    }

    // reset calculator
    public void ApplyCleanAll()
    {
        Equation = new Equation();
        ChangeState(new ConstructNumberState(this));
    }
}