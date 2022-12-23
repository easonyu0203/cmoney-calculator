using web_protocol;

namespace calculator;

/// <summary>
/// web client base calculator
/// </summary>
public class WebCalculator : ICalculator
{
    /// <summary>
    /// http client
    /// </summary>
    private static readonly HttpClient Client = new HttpClient();

    /// <summary>
    /// when update
    /// </summary>
    public Action? UpdateEvent { get; set; }

    /// <summary>
    /// result string
    /// </summary>
    public string ResultStr { get; private set; }

    /// <summary>
    /// equation string
    /// </summary>
    public string EquationStr { get; private set; }

    /// <summary>
    /// preorder string
    /// </summary>
    public string PreOrderStr { get; private set; }

    /// <summary>
    /// inorder string
    /// </summary>
    public string InOrderStr { get; private set; }

    /// <summary>
    /// postorder string
    /// </summary>
    public string PostOrderStr { get; private set; }

    /// <summary>
    /// guid of this calculator
    /// </summary>
    private readonly Guid _guid;

    /// <summary>
    /// request to create calculator
    /// </summary>
    public WebCalculator()
    {
        Guid guid = ServerEndpoint.CreateRequest(Client);
        _guid = guid;
        PreOrderStr = string.Empty;
        InOrderStr = string.Empty;
        PostOrderStr = string.Empty;
        ResultStr = StringConst.ZeroStr;
        EquationStr = string.Empty;
    }

    /// <summary>
    /// do nothing
    /// </summary>
    public void Init()
    {
    }

    /// <summary>
    /// call backend when zero action
    /// </summary>
    public void ApplyZeroAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.ZeroUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when number action
    /// </summary>
    public void ApplyNumberAction(int num)
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.NumberUrl}/{num}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when decimal action
    /// </summary>
    public void ApplyDecimalAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.DecimalUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when delete result string action
    /// </summary>
    public void ApplyDeleteResultStrAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.DeleteResultStrUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when clean result string action
    /// </summary>
    public void ApplyCleanResultStr()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.CleanResultStrUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when sign action
    /// </summary>
    public void ApplySignAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.SignUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when sqrt action
    /// </summary>
    public void ApplySqrtAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.SqrtUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when multiply action
    /// </summary>
    public void ApplyMultiplyAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.MultiplyUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when divide action
    /// </summary>
    public void ApplyDivideAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.DivideUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when plus action
    /// </summary>
    public void ApplyPlusAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.PlusUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when minus action
    /// </summary>
    public void ApplyMinusAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.MinusUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when equal action
    /// </summary>
    public void ApplyEqualAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.EqualUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when left parentheses action
    /// </summary>
    public void ApplyLeftParentheses()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.LeftParenthesesUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when right parentheses action
    /// </summary>
    public void ApplyRightParentheses()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.RightParenthesesUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    /// call backend when clean all action
    /// </summary>
    public void ApplyCleanAll()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.CleanAllUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    /// <summary>
    ///  set calculator context
    /// </summary>
    /// <param name="calculatorContext">context</param>
    private void SetContext(CalculatorContext calculatorContext)
    {
        ResultStr = calculatorContext.ResultStr;
        EquationStr = calculatorContext.EquationStr;
        PreOrderStr = calculatorContext.PreOrderStr;
        InOrderStr = calculatorContext.InOrderStr;
        PostOrderStr = calculatorContext.PostOrderStr;
    }
}