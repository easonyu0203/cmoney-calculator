namespace web_protocol;
using Newtonsoft.Json;

/// <summary>
/// for config server endpoint values and some helper function to send request
/// </summary>
public static class ServerEndpoint
{
    public const string Url = "http://localhost:5105";
    public const string CreateUrl = $"{Url}/create";
    public const string ZeroUrl = $"{Url}/0";
    public const string NumberUrl = $"{Url}";
    public const string DecimalUrl = $"{Url}/decimal";
    public const string DeleteResultStrUrl = $"{Url}/delete-result-str";
    public const string CleanResultStrUrl = $"{Url}/clean-result-str";
    public const string SignUrl = $"{Url}/sign";
    public const string SqrtUrl = $"{Url}/sqrt";
    public const string MultiplyUrl = $"{Url}/multiply";
    public const string DivideUrl = $"{Url}/divide";
    public const string PlusUrl = $"{Url}/plus";
    public const string MinusUrl = $"{Url}/minus";
    public const string EqualUrl = $"{Url}/equal";
    public const string LeftParenthesesUrl = $"{Url}/left-parentheses";
    public const string RightParenthesesUrl = $"{Url}/right-parentheses";
    public const string CleanAllUrl = $"{Url}/clean-all";

    /// <summary>
    /// send create request to server 
    /// </summary>
    /// <param name="client">http client</param>
    /// <returns>guid of created calculator</returns>
    public static Guid CreateRequest(HttpClient client)
    {
        HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, CreateUrl);
        HttpResponseMessage response = client.Send(requestMessage);
        Stream stream =  response.Content.ReadAsStream();
        StreamReader reader = new StreamReader(stream);
        string guidStr = reader.ReadToEnd().Trim('"');
        return new Guid(guidStr);
    }


    /// <summary>
    /// send http request message to server
    /// </summary>
    /// <param name="client">http client</param>
    /// <param name="requestMessage">server returned calculator context</param>
    /// <returns></returns>
    public static CalculatorContext SendRequest(HttpClient client, HttpRequestMessage requestMessage)
    {       
        HttpResponseMessage response = client.Send(requestMessage);
        Stream stream =  response.Content.ReadAsStream();
        StreamReader reader = new StreamReader(stream);
        string json = reader.ReadToEnd().Trim('"');
        CalculatorContext calculatorContext = JsonConvert.DeserializeObject<CalculatorContext>( json)!;
        return calculatorContext;
        
    }
    
}