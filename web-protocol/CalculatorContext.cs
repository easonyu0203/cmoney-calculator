namespace web_protocol;

public class CalculatorContext
{
    public string ResultStr { get; }

    public string EquationStr { get; }

    public string PreOrderStr { get; }

    public string InOrderStr { get; }

    public string PostOrderStr { get; }

    public CalculatorContext(string resultStr, string equationStr, string preOrderStr, string inOrderStr, string postOrderStr)
    {
        ResultStr = resultStr;
        EquationStr = equationStr;
        PreOrderStr = preOrderStr;
        InOrderStr = inOrderStr;
        PostOrderStr = postOrderStr;
    }
}