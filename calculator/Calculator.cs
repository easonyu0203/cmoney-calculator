using calculator.state_machine.expression;
using calculator.state_machine.result_str;

namespace calculator;

public class Calculator : ICalculator
{
    public Action? UpdateEvent { get; set; }

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
        UpdateEvent?.Invoke();
    }

    public void ApplyDecimalAction()
    {
        _resultStrStateMachine.ApplyDecimalAction();
        UpdateEvent?.Invoke();
    }

    public void ApplyDeleteResultStrAction()
    {
        _resultStrStateMachine.ApplyDeleteResultStrAction();
        UpdateEvent?.Invoke();
    }

    public void ApplySignAction()
    {
        _resultStrStateMachine.ApplySignAction();
        UpdateEvent?.Invoke();
    }

    public void ApplyCleanResultStr()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
        UpdateEvent?.Invoke();
    }

    public void ApplySqrtAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyMultiplyAction()
    {
        _expressionStateMachine.ApplyNumberAction(_resultStrStateMachine.ResultValue);
        _expressionStateMachine.ApplyMultiplyAction();

        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyDivideAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyPlusAction()
    {
        _expressionStateMachine.ApplyNumberAction(_resultStrStateMachine.ResultValue);
        _expressionStateMachine.ApplyPlusAction();
        
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyMinusAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyEqualAction()
    {
        _resultStrStateMachine = new ResultStrStateMachine(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyCleanAll()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
        UpdateEvent?.Invoke();
    }
}