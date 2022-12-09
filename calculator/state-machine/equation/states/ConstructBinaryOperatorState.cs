using calculator.EquationSystem;

namespace calculator.state_machine.equation.states;

public class ConstructBinaryOperatorState: EquationState
{
    private EquationStateMachine _equationStateMachine;
    private Action _addOperatorOnStateLeave;
    
    public ConstructBinaryOperatorState(EquationStateMachine stateMachine) : base(stateMachine)
    {
        _equationStateMachine = stateMachine;
        _addOperatorOnStateLeave = null!;
    }

    /// <summary>
    /// add to equation on state leave
    /// </summary>
    public override void OnStateLeave()
    {
        _addOperatorOnStateLeave.Invoke();
        _equationStateMachine.Equation.SetSuffixStr("");
    }
    
    public override void ApplyMultiplyAction()
    {
        _addOperatorOnStateLeave = () =>
        {
            _equationStateMachine.Equation.AddHighBinaryOperator(new MultiplyOperator());
        };
        _equationStateMachine.Equation.SetSuffixStr("x");
    } 

    public override void ApplyDivideAction()
    {
        _addOperatorOnStateLeave = () =>
        {
            _equationStateMachine.Equation.AddHighBinaryOperator(new DivideOperator());
        };
        _equationStateMachine.Equation.SetSuffixStr("/");
    } 

    public override void ApplyPlusAction()
    {
        _addOperatorOnStateLeave = () =>
        {
            _equationStateMachine.Equation.AddLowBinaryOperator(new PlusOperator());
        };
        _equationStateMachine.Equation.SetSuffixStr("+");
    } 

    public override void ApplyMinusAction()
    {
        _addOperatorOnStateLeave = () =>
        {
            _equationStateMachine.Equation.AddLowBinaryOperator(new MinusOperator());
        };
        _equationStateMachine.Equation.SetSuffixStr("-");
    } 

    // number manipulation action
    public override void ApplyZeroAction()
    {
        _stateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
    }

    public override void ApplyNumberAction(int num)
    {
        _stateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
    }

    public override void ApplyDecimalAction()
    {
        _stateMachine.ChangeState(new ConstructNumberState(_equationStateMachine));
    }

    // TODO: not sure what to do
    public override void ApplySqrtAction()
    {
    }

    /// <summary>
    /// add operator and reuslt string as operand to equation then calculate
    /// </summary>
    /// <returns></returns>
    public override decimal ApplyEqualAction()
    {
        // add operator
        _addOperatorOnStateLeave.Invoke();
        // add operand
        _equationStateMachine.Equation.AddOperand(new Operand(_equationStateMachine.ResultValue));
        // calculate
        decimal resultValue = _equationStateMachine.Equation.Calculate();
        // change state
        _equationStateMachine.ChangeState(new AfterEqualState(_equationStateMachine));
        return resultValue;
    }
}