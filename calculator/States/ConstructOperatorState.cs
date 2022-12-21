using calculator.states;

namespace calculator.States;

/// <summary>
/// state which are constructing operator
/// </summary>
public class ConstructOperatorState: CalculatorState
{
    /// <summary>
    /// reference of calculator
    /// </summary>
    private Calculator Calculator;
    /// <summary>
    /// prepared apply operator
    /// </summary>
    private Action ApplyOperator;
    
    public ConstructOperatorState(Calculator stateMachine, Action applyOperator, string operatorStr) : base(stateMachine)
    {
        Calculator = stateMachine;
        ApplyOperator = applyOperator;
        Calculator.EquationStrElements.Add(operatorStr);
    }
    
    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyMultiplyAction()
    {
        ApplyOperator = Calculator.EquationController.AddMultiplyOperator;
        Calculator.EquationStrElements[^1] = StringConst.MultiplyStr;
    } 

    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyDivideAction()
    {
        ApplyOperator = Calculator.EquationController.AddDivideOperator;
        Calculator.EquationStrElements[^1] = StringConst.DivideStr;
    } 
    
    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyPlusAction()
    {
        ApplyOperator = Calculator.EquationController.AddPlusOperator;
        Calculator.EquationStrElements[^1] = StringConst.PlusStr;
    } 

    /// <summary>
    /// switch chosen operator
    /// </summary>
    public override void ApplyMinusAction()
    {
        ApplyOperator = Calculator.EquationController.AddMinusOperator;
        Calculator.EquationStrElements[^1] = StringConst.MinusStr;
    } 

    // number manipulation action
    public override void ApplyZeroAction()
    {
        ApplyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(Calculator));
    }

    public override void ApplyNumberAction(int num)
    {
        ApplyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(Calculator));
    }

    public override void ApplyDecimalAction()
    {
        ApplyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(Calculator));
    }

    public override void ApplySignAction()
    {
        ApplyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(Calculator));
    }
    
    public override void ApplySqrtAction()
    {
        ApplyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(Calculator));
    }

    public override void ApplyLeftParentheses()
    {
        ApplyOperator.Invoke();
        _stateMachine.ChangeState(new ConstructNumberState(Calculator));
        ((CalculatorState)Calculator.CurrentState).ApplyLeftParentheses();
    }
}