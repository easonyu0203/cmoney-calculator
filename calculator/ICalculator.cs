namespace calculator;

public interface ICalculator
{
    public Action? UpdateEvent { get; set; }

    public string ResultStr { get; }
    public decimal ResultValue { get; }
    public string EquationStr { get; }

    // number manipulation action
    public void ApplyZeroAction();
    public void ApplyNumberAction(int num);
    public void ApplyDecimalAction();
    public void ApplyDeleteResultStrAction();
    public void ApplyCleanResultStr();

    // operator action
    public void ApplySignAction();
    public void ApplySqrtAction();
    public void ApplyMultiplyAction(); // *
    public void ApplyDivideAction(); // /
    public void ApplyPlusAction(); // +
    public void ApplyMinusAction(); // -
    public void ApplyEqualAction(); // =
    
    // reset calculator
    public void ApplyCleanAll();
}