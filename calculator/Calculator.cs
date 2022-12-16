using calculator.EquationSystem;
using calculator.state_machine;
using calculator.state_machine.result_str;

namespace calculator;

public class Calculator : ICalculator
{
    /// <summary>
    /// event fire when context update
    /// </summary>
    public Action? UpdateEvent { get; set; }
    
    // context
    /// <summary>
    /// displayed result string 
    /// </summary>
    public string ResultStr {get; private set;}
    /// <summary>
    /// result string in decimal value
    /// </summary>
    public decimal ResultValue => decimal.Parse(ResultStr);
    /// <summary>
    /// equation string
    /// </summary>
    public string EquationStr {get; private set;}
    
    /// <summary>
    /// The state machine which handle result string change due to actions
    /// </summary>
    private ResultStrStateMachine _resultStrStateMachine;

    private EquationStateMachine _equationStateMachine;


    public Calculator()
    {
        ResultStr = "0";
        EquationStr = "";
        
        // init result string state machine
        _resultStrStateMachine = new ResultStrStateMachine("0");
        _resultStrStateMachine.Init();
        // init equation state machine
        _equationStateMachine = new EquationStateMachine(this);
        _equationStateMachine.Init();

       
    }

    public void ApplyZeroAction()
    {
        _resultStrStateMachine.ApplyZeroAction();
        _equationStateMachine.ApplyZeroAction();

        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    public void ApplyNumberAction(int num)
    {
        _resultStrStateMachine.ApplyNumberAction(num);
        _equationStateMachine.ApplyNumberAction(num);
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    public void ApplyDecimalAction()
    {
        _resultStrStateMachine.ApplyDecimalAction();
        _equationStateMachine.ApplyDecimalAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    public void ApplyDeleteResultStrAction()
    {
        _resultStrStateMachine.ApplyDeleteResultStrAction();
        _equationStateMachine.ApplyDeleteResultStrAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    public void ApplySignAction()
    {
        _resultStrStateMachine.ApplySignAction();
        _equationStateMachine.ApplySignAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    public void ApplySqrtAction()
    {
        _resultStrStateMachine.ApplySignAction();
        _equationStateMachine.ApplySignAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    public void ApplyCleanResultStr()
    {
        _resultStrStateMachine.ReInit();
        _equationStateMachine.ApplyCleanResultStr();
        
        // apply
        ResultStr = "0";
        
        UpdateEvent?.Invoke();
    }

    public void ApplyMultiplyAction()
    {
        _equationStateMachine.ApplyMultiplyAction();
        _resultStrStateMachine.ReInit();
        
        
        UpdateEvent?.Invoke();
    }

    public void ApplyDivideAction()
    {
        _equationStateMachine.ApplyDivideAction();
        _resultStrStateMachine.ReInit();
        UpdateEvent?.Invoke();
    }

    public void ApplyPlusAction()
    {
        _equationStateMachine.ApplyPlusAction();
        _resultStrStateMachine.ReInit();
        UpdateEvent?.Invoke();
    }

    public void ApplyMinusAction()
    {
        _equationStateMachine.ApplyMinusAction();
        _resultStrStateMachine.ReInit();
        UpdateEvent?.Invoke();
    }

    public void ApplyEqualAction()
    {
        decimal resultValue = _equationStateMachine.ApplyEqualAction();
        _resultStrStateMachine.ReInit();
        
        // apply 
        ResultStr = $"{resultValue}";
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// clean result and equation
    /// </summary>
    public void ApplyCleanAll()
    {
        _resultStrStateMachine.ReInit();
        // init equation state machine
        _equationStateMachine = new EquationStateMachine(this);
        _equationStateMachine.Init();  
        
        // apply
        ResultStr = "0";
        EquationStr = "";
        
        UpdateEvent?.Invoke();
    }
}