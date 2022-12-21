using calculator;
using web_protocol;

namespace api_server;

/// <summary>
/// this is the manager of all calculator,
/// handle all hte calculator create action...
/// </summary>
public class CalculatorManager
{
    /// <summary>
    /// contain all calculaotr
    /// </summary>
    private Dictionary<Guid, Calculator> _calculators;

    public CalculatorManager()
    {
        _calculators = new Dictionary<Guid, Calculator>();
    }

    /// <summary>
    /// create calculator
    /// </summary>
    /// <returns>guid of calculaotr</returns>
    public Guid CreateCalculator()
    {
        Guid guid = Guid.NewGuid();
        Calculator calculator = new Calculator();
        calculator.Init();
        _calculators.Add(guid, calculator);
        return guid;
    }

    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyZeroAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyZeroAction();
        return Utilities.GetCalculatorContext(calculator);
    }

    /// <summary>
    ///  apply number action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <param name="num">num</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyNumberAction(Guid guid, int num)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyNumberAction(num);
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyDecimalAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyDecimalAction();
        return Utilities.GetCalculatorContext(calculator);
    }

    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyDeleteResultStrAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyDeleteResultStrAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyCleanResultStr(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyCleanResultStr();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplySignAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplySignAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplySqrtAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplySqrtAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyMultiplyAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyMultiplyAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyDivideAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyDivideAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyPlusAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyPlusAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyMinusAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyMinusAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyEqualAction(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyEqualAction();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyLeftParentheses(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyLeftParentheses();
        return Utilities.GetCalculatorContext(calculator);
    }
    
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyRightParentheses(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyRightParentheses();
        return Utilities.GetCalculatorContext(calculator);
    }
    
        
    /// <summary>
    ///  apply zero action to calculator guid
    /// </summary>
    /// <param name="guid">guid</param>
    /// <returns>context of calculator</returns>
    public CalculatorContext ApplyCleanAll(Guid guid)
    {
        Calculator calculator = _calculators[guid];
        calculator.ApplyCleanAll();
        return Utilities.GetCalculatorContext(calculator);
    }
}