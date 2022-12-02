using calculator.state_machine.expression;
using calculator.state_machine.result_str;

namespace calculator;

public class Calculator : ICalculatorController, ICalculatorDisplay
{
    public string ResultStr => _resultStrStateMachine.ResultStr;
    public string EquationStr => "";

    private ResultStrStateMachine _resultStrStateMachine;
    private ExpressionStateMachine _expressionStateMachine;

    public Calculator()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
        _resultStrStateMachine.Init();

        _expressionStateMachine = new ExpressionStateMachine();
        _expressionStateMachine.Init();
    }

    public void ApplyZeroAction()
    {
        _resultStrStateMachine.ApplyZeroAction();
    }

    public void ApplyNumberAction(int num)
    {
        _resultStrStateMachine.ApplyNumberAction(num);
    }

    public void ApplyDecimalAction()
    {
        _resultStrStateMachine.ApplyDecimalAction();
    }

    public void ApplyDeleteResultStrAction()
    {
        _resultStrStateMachine.ApplyDeleteResultStrAction();
    }

    public void ApplySignAction()
    {
        _resultStrStateMachine.ApplySignAction();
    }

    public void ApplyCleanResultStr()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
    }

    public void ApplySqrtAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
    }

    public void ApplyMultiplyAction()
    {
        _expressionStateMachine.ApplyNumberAction(_resultStrStateMachine.ResultValue);
        _expressionStateMachine.ApplyMultiplyAction();

        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
    }

    public void ApplyDivideAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
    }

    public void ApplyPlusAction()
    {
        _expressionStateMachine.ApplyNumberAction(_resultStrStateMachine.ResultValue);
        _expressionStateMachine.ApplyPlusAction();
        
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
    }

    public void ApplyMinusAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
    }

    public void ApplyEqualAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
    }

    public void ApplyCleanAll()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
    }
}