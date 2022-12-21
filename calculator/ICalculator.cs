namespace calculator;

/// <summary>
/// calculator interface
/// </summary>
public interface ICalculator
{
    /// <summary>
    /// fire on update
    /// </summary>
    public Action? UpdateEvent { get; set; }
    /// <summary>
    /// result string
    /// </summary>
    public string ResultStr { get; }
    /// <summary>
    /// equation string
    /// </summary>
    public string EquationStr { get; }
    /// <summary>
    /// pre order string of equation tree
    /// </summary>
    public string PreOrderStr { get; }
    /// <summary>
    /// pre order string of equation tree
    /// </summary>
    public string InOrderStr { get; }
    /// <summary>
    /// pre order string of equation tree
    /// </summary>
    public string PostOrderStr { get; }
    /// <summary>
    /// Call before any action
    /// </summary>
    public void Init();
    // number manipulation action
    /// <summary>
    /// apply zero action
    /// </summary>
    public void ApplyZeroAction();
    /// <summary>
    /// apply number action
    /// </summary>
    /// <param name="num">num</param>
    public void ApplyNumberAction(int num);
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyDecimalAction();
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyDeleteResultStrAction();
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyCleanResultStr();
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplySignAction();
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplySqrtAction();

    // operator action
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyMultiplyAction(); // *
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyDivideAction(); // /
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyPlusAction(); // +
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyMinusAction(); // -
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyEqualAction(); // =

    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyLeftParentheses();
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyRightParentheses();
    
    // reset calculator
    /// <summary>
    /// apply decimal action
    /// </summary>
    public void ApplyCleanAll();
}