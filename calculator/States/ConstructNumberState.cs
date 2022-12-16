using calculator.state_machine.equation;
using calculator.States;

namespace calculator.states;

public class ConstructNumberState : CalculatorState
{
    private readonly Calculator _calculator;

    public ConstructNumberState(Calculator calculator) : base(calculator)
    {
        _calculator = calculator;
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
        _calculator.EquationStrElements.Add(_calculator.ResultStr);
        _calculator.EquationController.AddOperand(_calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(_calculator, _calculator.EquationController.AddMultiplyOperator, StringConst.MultiplyStr));
    }

    public override void ApplyDivideAction()
    {
        _calculator.EquationStrElements.Add(_calculator.ResultStr);
        _calculator.EquationController.AddOperand(_calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(_calculator, _calculator.EquationController.AddDivideOperator, StringConst.DivideStr));
    }

    public override void ApplyPlusAction()
    {
        _calculator.EquationStrElements.Add(_calculator.ResultStr);
        _calculator.EquationController.AddOperand(_calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(_calculator, _calculator.EquationController.AddPlusOperator, StringConst.PlusStr));
        ;
    }

    public override void ApplyMinusAction()
    {
        _calculator.EquationStrElements.Add(_calculator.ResultStr);
        _calculator.EquationController.AddOperand(_calculator.ResultValue);
        _stateMachine.ChangeState(new ConstructOperatorState(_calculator, _calculator.EquationController.AddMinusOperator, StringConst.MinusStr));
    }

    public override void ApplyLeftParentheses()
    {
        _calculator.EquationStrElements.Add(StringConst.LeftParentheses);
        _calculator.EquationController.AddLeftParentheses();
    }

    public override void ApplyEqualAction()
    {
        // the last operand will always be result string
        _calculator.EquationController.AddOperand(_calculator.ResultValue);
        _calculator.EquationStrElements.Add(_calculator.ResultStr);
    }
}