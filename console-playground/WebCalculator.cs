using calculator;
using web_protocol;

namespace console_playground;

/// <summary>
/// web client base calculator
/// </summary>
public class WebCalculator : ICalculator
{
    private static readonly HttpClient Client = new HttpClient();

    public Action? UpdateEvent { get; set; }
    public string ResultStr { get; private set; }
    public string EquationStr { get; private set; }
    public string PreOrderStr { get; private set; }
    public string InOrderStr { get; private set; }
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

    public void ApplyZeroAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.ZeroUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyNumberAction(int num)
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.NumberUrl}/{num}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyDecimalAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.DecimalUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyDeleteResultStrAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.DeleteResultStrUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyCleanResultStr()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.CleanResultStrUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplySignAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.SignUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplySqrtAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.SqrtUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyMultiplyAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.MultiplyUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyDivideAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.DivideUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyPlusAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.PlusUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyMinusAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.MinusUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyEqualAction()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.EqualUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyLeftParentheses()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.LeftParenthesesUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

    public void ApplyRightParentheses()
    {
        HttpRequestMessage requestMessage =
            new HttpRequestMessage(HttpMethod.Post, $"{ServerEndpoint.RightParenthesesUrl}/{_guid}");
        CalculatorContext calculatorContext = ServerEndpoint.SendRequest(Client, requestMessage);
        SetContext(calculatorContext);
        UpdateEvent?.Invoke();
    }

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