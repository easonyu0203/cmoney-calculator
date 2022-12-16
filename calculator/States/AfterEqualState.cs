using calculator.state_machine.equation;
using calculator.states;

namespace calculator.States;

public class AfterEqualState:CalculatorState
{
    private Calculator _calculator;
    
    public AfterEqualState(Calculator stateMachine) : base(stateMachine)
    {
        _calculator = stateMachine;
    }
    

    public override void ApplyZeroAction()
    {
        _calculator.ApplyCleanAll();
    }

    public override void ApplyNumberAction(int num)
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyNumberAction(num);
    }

    public override void ApplyDecimalAction()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyDecimalAction();
    }

    public override void ApplySqrtAction()
    {
        _calculator.ApplyCleanAll();
    }

    public override void ApplyMultiplyAction()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyMultiplyAction();
    } 

    public override void ApplyDivideAction()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyDivideAction();
    } 

    public override void ApplyPlusAction()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyPlusAction();
    } 

    public override void ApplyMinusAction()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyMinusAction();
    }

    public override void ApplyLeftParentheses()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyLeftParentheses();
    }
    
    public override void ApplyRightParentheses()
    {
        _calculator.ApplyCleanAll();
        _calculator.ApplyRightParentheses();
    }
}