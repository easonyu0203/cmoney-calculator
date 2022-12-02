using calculator.state_machine.result_str;

namespace calculator.state_machine.calculator.states;

public class ConstructResultStrState: CalculatorState
{
    private ResultStrStateMachine _resultStrStateMachine;
    
    public ConstructResultStrState(CalculatorData calculatorData, string placeHolder, StateMachine stateMachine) : base(calculatorData, stateMachine)
    {
        _resultStrStateMachine = new ResultStrStateMachine(placeHolder);
    }
    
    public override void OnStateEnter()
    {
    }

    /// <summary>
    /// result str state machine handle
    /// </summary>
    public override void ApplyZeroAction()
    {
        _resultStrStateMachine.ApplyZeroAction();
        CalculatorData.ResultStr = _resultStrStateMachine.ResultStr;
    }

    public override void ApplyNumberAction(int num)
    {
        _resultStrStateMachine.ApplyNumberAction(num);
        CalculatorData.ResultStr = _resultStrStateMachine.ResultStr;
    }

    public override void ApplyDecimalAction()
    {
        _resultStrStateMachine.ApplyDecimalAction();
        CalculatorData.ResultStr = _resultStrStateMachine.ResultStr;
    }

    public override void ApplyDeleteResultStrAction()
    {
        _resultStrStateMachine.ApplyDeleteResultStrAction();
        CalculatorData.ResultStr = _resultStrStateMachine.ResultStr;
    }

    public override void ApplyCleanResultStr()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
    }

    public override void ApplySignAction()
    {
        _resultStrStateMachine.ApplySignAction();
        CalculatorData.ResultStr = _resultStrStateMachine.ResultStr;
    }

    public override void ApplySqrtAction()
    {
    }

    public override void ApplyMultiplyAction()
    {
    }

    public override void ApplyDivideAction()
    {
    }

    public override void ApplyPlusAction()
    {
    }

    public override void ApplyMinusAction()
    {
    }

    public override void ApplyEqualAction()
    {
    }

    public override void ApplyCleanAll()
    {
    }


}