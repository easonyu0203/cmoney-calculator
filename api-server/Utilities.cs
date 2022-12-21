using calculator;
using web_protocol;

namespace api_server;

/// <summary>
/// some utilities functions
/// </summary>
public static class Utilities
{
    /// <summary>
    /// get current calculator context
    /// </summary>
    /// <param name="calculator">calculator</param>
    /// <returns></returns>
    public static CalculatorContext GetCalculatorContext(ICalculator calculator)
    {
        return new CalculatorContext(calculator.ResultStr, calculator.EquationStr, calculator.PreOrderStr,
            calculator.InOrderStr, calculator.PostOrderStr);
    }
}