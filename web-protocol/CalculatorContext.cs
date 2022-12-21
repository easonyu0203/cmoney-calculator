namespace web_protocol;

/// <summary>
/// calculator context which server will send back
/// </summary>
public class CalculatorContext
{
    /// <summary>
    /// result string
    /// </summary>
    public string ResultStr { get; }

    /// <summary>
    /// equation string
    /// </summary>
    public string EquationStr { get; }

    /// <summary>
    /// equation string
    /// </summary>
    public string PreOrderStr { get; }

    /// <summary>
    /// inorder string
    /// </summary>
    public string InOrderStr { get; }

    /// <summary>
    /// postorder string
    /// </summary>
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