using calculator.EquationSystem;
using calculator.state_machine;
using calculator.state_machine.result_str;

namespace calculator;

public class Calculator : ICalculator
{
    public Action? UpdateEvent { get; set; }

    public string ResultStr => _resultStrStateMachine.ResultStr;
    public decimal ResultValue => _resultStrStateMachine.ResultValue;
    public string EquationStr => _equationStateMachine.Equation.ToString();

    /// <summary>
    /// The state machine which handle result string change due to actions
    /// </summary>
    private readonly ResultStrStateMachine _resultStrStateMachine;

    private EquationStateMachine _equationStateMachine;


    public Calculator()
    {
        // init result string state machine
        _resultStrStateMachine = new ResultStrStateMachine("0");
        _resultStrStateMachine.Init();
        // init equation state machine
        _equationStateMachine = new EquationStateMachine(this);
        _equationStateMachine.Init();       
    }

    public void ApplyZeroAction()
    {
        _equationStateMachine.ApplyZeroAction();
        _resultStrStateMachine.ApplyZeroAction();
        UpdateEvent?.Invoke();
    }

    public void ApplyNumberAction(int num)
    {
        _equationStateMachine.ApplyNumberAction(num);
        _resultStrStateMachine.ApplyNumberAction(num);
        UpdateEvent?.Invoke();
    }

    public void ApplyDecimalAction()
    {
        _equationStateMachine.ApplyDecimalAction();
        _resultStrStateMachine.ApplyDecimalAction();
        UpdateEvent?.Invoke();
    }

    public void ApplyDeleteResultStrAction()
    {
        _equationStateMachine.ApplyDeleteResultStrAction();
        _resultStrStateMachine.ApplyDeleteResultStrAction();
        UpdateEvent?.Invoke();
    }

    public void ApplySignAction()
    {
        _equationStateMachine.ApplySignAction();
        _resultStrStateMachine.ApplySignAction();
        UpdateEvent?.Invoke();
    }

    public void ApplyCleanResultStr()
    {
        _equationStateMachine.ApplyCleanResultStr();
        _resultStrStateMachine.ReInitWithPlaceHolder("0");
        UpdateEvent?.Invoke();
    }

    public void ApplySqrtAction()
    {
        _equationStateMachine.ApplySqrtAction();
        _resultStrStateMachine.ReInitWithPlaceHolder(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyMultiplyAction()
    {
        _equationStateMachine.ApplyMultiplyAction();
        _resultStrStateMachine.ReInitWithPlaceHolder(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyDivideAction()
    {
        _equationStateMachine.ApplyDivideAction();
        _resultStrStateMachine.ReInitWithPlaceHolder(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyPlusAction()
    {
        _equationStateMachine.ApplyPlusAction();
        _resultStrStateMachine.ReInitWithPlaceHolder(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyMinusAction()
    {
        _equationStateMachine.ApplyMinusAction();
        _resultStrStateMachine.ReInitWithPlaceHolder(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }

    public void ApplyEqualAction()
    {
        decimal resultValue = _equationStateMachine.ApplyEqualAction();
        _resultStrStateMachine.ReInitWithPlaceHolder($"{resultValue}");
        UpdateEvent?.Invoke();
    }

    public void ApplyCleanAll()
    {
        _equationStateMachine.ApplyCleanAll();
        _resultStrStateMachine.ReInitWithPlaceHolder(_resultStrStateMachine.ResultStr);
        UpdateEvent?.Invoke();
    }
}