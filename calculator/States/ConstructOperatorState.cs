using calculator.state_machine.equation;
using calculator.states;

namespace calculator.States;

public class ConstructOperatorState: CalculatorState
{
    private Calculator _calculator;
    private Action _applyOperator;
    
    public ConstructOperatorState(Calculator stateMachine, Action applyOperator, string operatorStr) : base(stateMachine)
    {
        _calculator = stateMachine;
        _applyOperator = applyOperator;
        _calculator.EquationStrElements.Add(operatorStr);
    }
    
    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyMultiplyAction()
    {
        _applyOperator = _calculator.EquationController.AddMultiplyOperator;
        _calculator.EquationStrElements[^1] = StringConst.MultiplyStr;
    } 

    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyDivideAction()
    {
        _applyOperator = _calculator.EquationController.AddDivideOperator;
        _calculator.EquationStrElements[^1] = StringConst.DivideStr;
    } 
    
    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyPlusAction()
    {
        _applyOperator = _calculator.EquationController.AddPlusOperator;
        _calculator.EquationStrElements[^1] = StringConst.PlusStr;
    } 

    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyMinusAction()
    {
        _applyOperator = _calculator.EquationController.AddMinusOperator;
        _calculator.EquationStrElements[^1] = StringConst.MinusStr;
    } 

    // number manipulation action
    public override void ApplyZeroAction()
    {
        _applyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(_calculator));
    }

    public override void ApplyNumberAction(int num)
    {
        _applyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(_calculator));
    }

    public override void ApplyDecimalAction()
    {
        _applyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(_calculator));
    }

    public override void ApplySignAction()
    {
        _applyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(_calculator));
    }
    
    public override void ApplySqrtAction()
    {
        _applyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(_calculator));
    }

    public override void ApplyLeftParentheses()
    {
        _applyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(_calculator));
        ((CalculatorState)_calculator.CurrentState).ApplyLeftParentheses();
    }
}