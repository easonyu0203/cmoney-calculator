using calculator.EquationSystem;

namespace calculator.state_machine.equation.states;

public class ConstructNumberState : EquationState
{
    private EquationStateMachine _equationStateMachine;
    private UnaryExpression _unaryExpression;

    public ConstructNumberState(EquationStateMachine stateMachine) : base(stateMachine)
    {
        _equationStateMachine = stateMachine;
        _unaryExpression = new UnaryExpression(_equationStateMachine.ResultValue);
    }

    /// <summary>
    /// add unary expression to equation
    /// </summary>
    public override void OnStateLeave()
    {
        _equationStateMachine.Equation.AddOperand(_unaryExpression);
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplyZeroAction()
    {
        _unaryExpression.RawNumber = _equationStateMachine.ResultValue;
        _unaryExpression.UnaryOperators.Clear();
        _equationStateMachine.Equation.SetSuffixStr("");
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplyNumberAction(int num)
    {
        _unaryExpression.RawNumber = _equationStateMachine.ResultValue;
        _unaryExpression.UnaryOperators.Clear();
        _equationStateMachine.Equation.SetSuffixStr("");
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplyDecimalAction()
    {
        _unaryExpression.RawNumber = _equationStateMachine.ResultValue;
        _unaryExpression.UnaryOperators.Clear();
        _equationStateMachine.Equation.SetSuffixStr("");
    }

    /// <summary>
    ///  clear unary operator if user try to build new number
    /// </summary>
    public override void ApplySignAction()
    {
        _unaryExpression.RawNumber = _equationStateMachine.ResultValue;
        _unaryExpression.UnaryOperators.Clear();
        _equationStateMachine.Equation.SetSuffixStr("");
    }

    /// <summary>
    /// add sqrt operator to unary operator list
    /// </summary>
    public override decimal ApplySqrtAction()
    {
        _unaryExpression.UnaryOperators.Add(new SqrtOperator());
        _equationStateMachine.Equation.SetSuffixStr(_unaryExpression.ToString());
        return _unaryExpression.Value;
    }

    /// <summary>
    /// change to construct operand state
    /// </summary>
    public override void ApplyMultiplyAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyMultiplyAction();
    }

    public override void ApplyDivideAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyDivideAction();
    }

    public override void ApplyPlusAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyPlusAction();
        ;
    }

    public override void ApplyMinusAction()
    {
        _stateMachine.ChangeState(new ConstructBinaryOperatorState(_equationStateMachine));
        _equationStateMachine.ApplyMinusAction();
    }


    /// <summary>
    /// add an operand to equation and calculate result
    /// </summary>
    /// <returns></returns>
    public override decimal ApplyEqualAction()
    {
        _equationStateMachine.ChangeState(new AfterEqualState(_equationStateMachine));
        decimal resultValue = _equationStateMachine.Equation.Calculate();
        _equationStateMachine.Equation.SetSuffixStr("=");
        return resultValue;
    }
}