using calculator.EquationSystem;
using calculator.ResultStringSystem;
using calculator.state_machine;
using calculator.StateDesign;
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
    public string ResultStr { get; private set; }

    /// <summary>
    /// result string in decimal value
    /// </summary>
    public decimal ResultValue => decimal.Parse(ResultStr);

    /// <summary>
    /// equation string
    /// </summary>
    public string EquationStr => string.Join(' ', EquationStrElements);

    /// <summary>
    /// preorder string
    /// </summary>
    public string PreOrderStr { get; private set; }

    /// <summary>
    /// preorder string
    /// </summary>
    public string InOrderStr { get; private set; }

    /// <summary>
    /// preorder string
    /// </summary>
    public string PostOrderStr { get; private set; }

    /// <summary>
    /// object to manipulate equation
    /// </summary>
    public EquationController EquationController;

    /// <summary>
    /// The state machine which handle result string change due to actions
    /// </summary>
    private readonly ResultStrStateMachine ResultStrStateMachine;

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
        PreOrderStr = string.Empty;
        InOrderStr = string.Empty;
        PostOrderStr = string.Empty;

        // init result string state machine
        ResultStrStateMachine = new ResultStrStateMachine(StringConst.ZeroStr);
        ResultStrStateMachine.Init();
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
        ResultStrStateMachine.ApplyZeroAction();
        CurrentCalculatorState.ApplyZeroAction();

        // apply
        ResultStr = ResultStrStateMachine.ResultStr;

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string manipulation by append number
    /// </summary>
    public void ApplyNumberAction(int num)
    {
        ResultStrStateMachine.ApplyNumberAction(num);
        CurrentCalculatorState.ApplyNumberAction(num);

        // apply
        ResultStr = ResultStrStateMachine.ResultStr;

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string manipulation by append decimal
    /// </summary>
    public void ApplyDecimalAction()
    {
        ResultStrStateMachine.ApplyDecimalAction();
        CurrentCalculatorState.ApplyDecimalAction();

        // apply
        ResultStr = ResultStrStateMachine.ResultStr;

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string manipulation by to previous result string
    /// </summary>
    public void ApplyDeleteResultStrAction()
    {
        ResultStrStateMachine.ApplyDeleteResultStrAction();
        CurrentCalculatorState.ApplyDeleteResultStrAction();

        // apply
        ResultStr = ResultStrStateMachine.ResultStr;

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string * -1
    /// </summary>
    public void ApplySignAction()
    {
        ResultStrStateMachine.ApplySignAction();
        CurrentCalculatorState.ApplySignAction();

        // apply
        ResultStr = ResultStrStateMachine.ResultStr;

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// sqrt is a result string manipulation method as number and sign action
    /// </summary>
    public void ApplySqrtAction()
    {
        ResultStrStateMachine.ApplySqrtAction();
        CurrentCalculatorState.ApplySqrtAction();

        // apply
        ResultStr = ResultStrStateMachine.ResultStr;

        // clean up
        ResultStrStateMachine.ReInit();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// clean result string to "0"
    /// </summary>
    public void ApplyCleanResultStr()
    {
        ResultStrStateMachine.ReInit();
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
        ResultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyMultiplyAction();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyDivideAction()
    {
        ResultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyDivideAction();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyPlusAction()
    {
        ResultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyPlusAction();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// result string finish construct number and use by equation state machine, clean up result state machine
    /// </summary>
    public void ApplyMinusAction()
    {
        ResultStrStateMachine.ReInit();
        CurrentCalculatorState.ApplyMinusAction();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// get equation result and set result string as result and clean result string state machine
    /// </summary>
    public void ApplyEqualAction()
    {
        try
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
        catch (Exception)
        {
            CleanUpStateAndUi();
        }
    }

    /// <summary>
    /// equation add parentheses
    /// </summary>
    public void ApplyLeftParentheses()
    {
        CurrentCalculatorState.ApplyLeftParentheses();

        ResultStrStateMachine.ReInit();
        ResultStr = StringConst.LeftParentheses;

        UpdateEvent?.Invoke();
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

        ResultStrStateMachine.ReInit();
        ResultStr = StringConst.RightParentheses;

        CurrentCalculatorState.ApplyRightParentheses();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// clean result and equation
    /// </summary>
    public void ApplyCleanAll()
    {
        CleanUpStateAndUi();

        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// clean up all the state context ui of calculator
    /// </summary>
    private void CleanUpStateAndUi()
    {
        // clean up
        ResultStrStateMachine.ReInit();
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