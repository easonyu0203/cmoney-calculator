namespace calculator;

public interface ICalculator
{
    public Action? UpdateEvent { get; set; }
    
    public string ResultStr { get; }
    public string EquationStr { get; }
    public string PreOrderStr { get; }
    public string InOrderStr { get; }
    public string PostOrderStr { get; }
    public void Init();
    // number manipulation action
    public void ApplyZeroAction();
    public void ApplyNumberAction(int num);
    public void ApplyDecimalAction();
    public void ApplyDeleteResultStrAction();
    public void ApplyCleanResultStr();
    public void ApplySignAction();
    public void ApplySqrtAction();

    // operator action
    public void ApplyMultiplyAction(); // *
    public void ApplyDivideAction(); // /
    public void ApplyPlusAction(); // +
    public void ApplyMinusAction(); // -
    public void ApplyEqualAction(); // =

    public void ApplyLeftParentheses();
    public void ApplyRightParentheses();
    
    // reset calculator
    public void ApplyCleanAll();
}