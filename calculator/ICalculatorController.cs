namespace calculator;

public interface ICalculatorController
{
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