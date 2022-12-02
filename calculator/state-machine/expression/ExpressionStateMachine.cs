using System.Text;
using calculator.state_machine.expression.Operators;
using calculator.state_machine.expression.States;

namespace calculator.state_machine.expression;

public class ExpressionStateMachine : StateMachine
{
    public string EquationStr
    {
        get
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Operators.Count; i++)
            {
                stringBuilder.Append(Operands[i]);
                stringBuilder.Append(Operators[i]);
            }
            stringBuilder.Append(Operands[^1]);
            return stringBuilder.ToString();
        }
    }

    public List<Operand> Operands;
    public List<IOperator> Operators;

    private ExpressionState CurrentExpressionState => (ExpressionState)CurrentState;

    public ExpressionStateMachine()
    {
        Operands = new(){new Operand(0)};
        Operators = new();
    }
    
    protected override State GetInitState()
    {
        return new FirstSetOperandState(this);
    }

    public void ApplyNumberAction(decimal number)
    {
        CurrentExpressionState.ApplyNumberAction(number);
    }

    public void ApplySqrtAction()
    {
        CurrentExpressionState.ApplySqrtAction();
    }

    public void ApplyMultiplyAction()
    {
        CurrentExpressionState.ApplyMultiplyAction();
    }

    public void ApplyDivideAction()
    {
    }

    public void ApplyPlusAction()
    {
        CurrentExpressionState.ApplyPlusAction();;
    }

    public void ApplyMinusAction()
    {
    }
}