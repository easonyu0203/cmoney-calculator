using calculator.states;

namespace calculator.States;

/// <summary>
/// the state after apply equation action
/// </summary>
public class AfterEqualState : CalculatorState
{
    /// <summary>
    /// reference of calculator
    /// </summary>
    private Calculator Calculator;

    public AfterEqualState(Calculator stateMachine) : base(stateMachine)
    {
        Calculator = stateMachine;
    }


    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyZeroAction()
    {
        Calculator.ApplyCleanAll();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyNumberAction(int num)
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyNumberAction(num);
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyDecimalAction()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyDecimalAction();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplySqrtAction()
    {
        Calculator.ApplyCleanAll();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyMultiplyAction()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyMultiplyAction();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyDivideAction()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyDivideAction();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyPlusAction()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyPlusAction();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyMinusAction()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyMinusAction();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyLeftParentheses()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyLeftParentheses();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyRightParentheses()
    {
        Calculator.ApplyCleanAll();
        Calculator.ApplyRightParentheses();
    }
}