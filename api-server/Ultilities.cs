using calculator;
using web_protocol;

namespace api_server;

public static class Ultilities
{
    public static CalculatorContext GetCalculatorContext(ICalculator calculator)
    {
        return new CalculatorContext(calculator.ResultStr, calculator.EquationStr, calculator.PreOrderStr,
            calculator.InOrderStr, calculator.PostOrderStr);
    }
}