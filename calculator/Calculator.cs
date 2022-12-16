using calculator.EquationSystem;
using calculator.state_machine;
using calculator.state_machine.equation;
using calculator.state_machine.result_str;
using calculator.states;
using calculator.States;

namespace calculator;

/// <summary>
/// calculator is also implementing state machine
/// </summary>
public class Calculator : StateMachine, ICalculator
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
    public string EquationStr => string.Join(' ', EquationStrElements);

    public string PreOrderStr { get; private set;}
    public string InOrderStr { get; private set;}
    public string PostOrderStr { get; private set;}

    /// <summary>
    /// object to manipulate equation
    /// </summary>
    public EquationController EquationController;
    /// <summary>
    /// The state machine which handle result string change due to actions
    /// </summary>
    private readonly ResultStrStateMachine _resultStrStateMachine;
    /// <summary>
    /// current state of calculator state machine
    /// </summary>
    private CalculatorState CurrentCalculatorState => (CalculatorState)CurrentState;

    /// <summary>
    /// equation string elements
    /// </summary>
    public List<string> EquationStrElements; 

    public Calculator()
    {
        ResultStr = StringConst.ZeroStr;
        EquationStrElements = new List<string>();
        EquationController = new EquationController();
        PreOrderStr = "";
        InOrderStr = "";
        PostOrderStr = "";
        
        // init result string state machine
        _resultStrStateMachine = new ResultStrStateMachine("0");
        _resultStrStateMachine.Init();
       
    }
    
    /// <summary>
    /// init state should be construct number
    /// </summary>
    /// <returns>construct number state</returns>
    protected override State GetInitState()
    {
        return new ConstructNumberState(this);
    }

    /// <summary>
    /// result string manipulation by append zero
    /// </summary>
    public void ApplyZeroAction()
    {
        _resultStrStateMachine.ApplyZeroAction();
        CurrentCalculatorState.ApplyZeroAction();

        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string manipulation by append number
    /// </summary>
    public void ApplyNumberAction(int num)
    {
        _resultStrStateMachine.ApplyNumberAction(num);
        CurrentCalculatorState.ApplyNumberAction(num);
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string manipulation by append decimal
    /// </summary>
    public void ApplyDecimalAction()
    {
        _resultStrStateMachine.ApplyDecimalAction();
        CurrentCalculatorState.ApplyDecimalAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string manipulation by to previous result string
    /// </summary>
    public void ApplyDeleteResultStrAction()
    {
        _resultStrStateMachine.ApplyDeleteResultStrAction();
        CurrentCalculatorState.ApplyDeleteResultStrAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string * -1
    /// </summary>
    public void ApplySignAction()
    {
        _resultStrStateMachine.ApplySignAction();
        CurrentCalculatorState.ApplySignAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// sqrt is a result string manipulation method as number and sign action
    /// </summary>
    public void ApplySqrtAction()
    {
        _resultStrStateMachine.ApplySqrtAction();
        CurrentCalculatorState.ApplySqrtAction();
        
        // apply
        ResultStr = _resultStrStateMachine.ResultStr;
        
        // clean up
        _resultStrStateMachine.ReInit(); 
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// clean result string to "0"
    /// </summary>
    public void ApplyCleanResultStr()
    {
        _resultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyCleanResultStr();
        
        // apply
        ResultStr = StringConst.ZeroStr;
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyMultiplyAction()
    {
        _resultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyMultiplyAction();
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyDivideAction()
    {
        _resultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyDivideAction();
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyPlusAction()
    {
        _resultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyPlusAction();
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyMinusAction()
    {
        _resultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyMinusAction();
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// get equation result and set result string as result and clean result string state machine
    /// </summary>
    public void ApplyEqualAction()
    {
        CurrentCalculatorState.ApplyEqualAction();
        
        // calculate
        var (equationResult, preorder, inorder, postorder) = EquationController.CalculateResult();
        
        // apply 
        ResultStr = $"{equationResult}";
        PreOrderStr = preorder;
        InOrderStr = inorder;
        PostOrderStr = postorder;
        EquationStrElements.Add(StringConst.Equal);
        
        ChangeState(new AfterEqualState(this));
        
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// equation add parentheses
    /// </summary>
    public void ApplyLeftParentheses()
    {
        
        CurrentCalculatorState.ApplyLeftParentheses();
        
        _resultStrStateMachine.ReInit();
        ResultStr = StringConst.LeftParentheses;
    }

    /// <summary>
    /// equation add parentheses
    /// </summary>
    public void ApplyRightParentheses()
    {
        EquationStrElements.Add(ResultStr);
        EquationController.AddOperand(ResultValue);
        ChangeState(new ConstructOperatorState(this, () => { }, ""));
        EquationController.AddRightParentheses();
        EquationStrElements[^1] = StringConst.RightParentheses;
        EquationStrElements.Add(string.Empty);
        
        _resultStrStateMachine.ReInit();
        ResultStr = StringConst.RightParentheses;
        
        CurrentCalculatorState.ApplyRightParentheses();
    }

    /// <summary>
    /// clean result and equation
    /// </summary>
    public void ApplyCleanAll()
    {
        CleanUpStateAndUi();
        
        UpdateEvent?.Invoke();
    }

    private void CleanUpStateAndUi()
    {
        // clean up
        _resultStrStateMachine.ReInit();
        EquationController = new EquationController();
        ChangeState(new ConstructNumberState(this));
        
        // apply
        ResultStr = StringConst.ZeroStr;
        EquationStrElements = new List<string>();
        PreOrderStr = "";
        InOrderStr = "";
        PostOrderStr = "";
    }
}