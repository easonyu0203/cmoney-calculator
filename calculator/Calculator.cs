using calculator.state_machine.calculator;
using calculator.state_machine.result_str;

namespace calculator;

public class CalculatorData
{
    public string ResultStr;
    public string EquationStr;

    public CalculatorData(string resultStr, string equationStr)
    {
        ResultStr = resultStr;
        EquationStr = equationStr;
    }
}

public class Calculator : ICalculatorController, ICalculatorDisplay
{
    public string ResultStr => _resultStrStateMachine.ResultStr;
    public string EquationStr => "";

    private ResultStrStateMachine _resultStrStateMachine;

    public Calculator()
    {
        _resultStrStateMachine = new ResultStrStateMachine("0");
        _resultStrStateMachine.Init();
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

    public void ApplyCleanResultStr()
    {
        _resultStrStateMachine.ApplyCleanResultStr();
    }

    public void ApplySignAction()
    {
        _resultStrStateMachine.ApplySignAction();
    }

    public void ApplySqrtAction()
    {
        
    }

    public void ApplyMultiplyAction()
    {
        
    }

    public void ApplyDivideAction()
    {
        
    }

    public void ApplyPlusAction()
    {
        
    }

    public void ApplyMinusAction()
    {
        
    }

    public void ApplyEqualAction()
    {
        
    }

    public void ApplyCleanAll()
    {
        
    }
}