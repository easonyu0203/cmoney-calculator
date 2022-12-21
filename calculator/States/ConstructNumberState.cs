using calculator.States;

namespace calculator.states;

/// <summary>
/// state which are constructing number
/// </summary>
public class ConstructNumberState : CalculatorState
{
    /// <summary>
    /// reference of calculator
    /// </summary>
    private readonly Calculator Calculator;

    public ConstructNumberState(Calculator calculator) : base(calculator)
    {
        Calculator = calculator;
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplyZeroAction()
    {
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplyNumberAction(int num)
    {
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplyDecimalAction()
    {
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplySignAction()
    {
    }

    /// <summary>
    /// add sqrt operator to unary operator list
    /// </summary>
    public override void ApplySqrtAction()
    {
    }

    /// <summary>
    /// change to construct operand state
    /// </summary>
    public override void ApplyMultiplyAction()
    {
        Calculator.EquationStrElements.Add(Calculator.ResultStr);
        Calculator.EquationController.AddOperand(Calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(Calculator, Calculator.EquationController.AddMultiplyOperator, StringConst.MultiplyStr));
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyDivideAction()
    {
        Calculator.EquationStrElements.Add(Calculator.ResultStr);
        Calculator.EquationController.AddOperand(Calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(Calculator, Calculator.EquationController.AddDivideOperator, StringConst.DivideStr));
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyPlusAction()
    {
        Calculator.EquationStrElements.Add(Calculator.ResultStr);
        Calculator.EquationController.AddOperand(Calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(Calculator, Calculator.EquationController.AddPlusOperator, StringConst.PlusStr));
        ;
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyMinusAction()
    {
        Calculator.EquationStrElements.Add(Calculator.ResultStr);
        Calculator.EquationController.AddOperand(Calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(Calculator, Calculator.EquationController.AddMinusOperator, StringConst.MinusStr));
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyLeftParentheses()
    {
        Calculator.EquationStrElements.Add(StringConst.LeftParentheses);
        Calculator.EquationController.AddLeftParentheses();
    }

    /// <summary>
    /// apply zero action
    /// </summary>
    public override void ApplyEqualAction()
    {
        // the last operand will always be result string
        Calculator.EquationController.AddOperand(Calculator.ResultValue);
        Calculator.EquationStrElements.Add(Calculator.ResultStr);
    }
}