using api_server;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

CalculatorManager calculatorManager = new CalculatorManager();

app.MapGet("/", () => "Hello World!");
app.MapPost("/create", () =>  calculatorManager.CreateCalculator());
app.MapPost("/0/{guid}", (Guid guid) => calculatorManager.ApplyZeroAction(guid));
app.MapPost("/{num}/{guid}", (int num, Guid guid) => calculatorManager.ApplyNumberAction(guid, num));
app.MapPost("/decimal/{guid}", (Guid guid) => calculatorManager.ApplyDecimalAction(guid));
app.MapPost("/delete-result-str/{guid}", (Guid guid) => calculatorManager.ApplyDeleteResultStrAction(guid));
app.MapPost("/clean-result-str/{guid}", (Guid guid) => calculatorManager.ApplyCleanResultStr(guid));
app.MapPost("/sign/{guid}", (Guid guid) => calculatorManager.ApplySignAction(guid));
app.MapPost("/sqrt/{guid}", (Guid guid) => calculatorManager.ApplySqrtAction(guid));
app.MapPost("/multiply/{guid}", (Guid guid) => calculatorManager.ApplyMultiplyAction(guid));
app.MapPost("/divide/{guid}", (Guid guid) => calculatorManager.ApplyDivideAction(guid));
app.MapPost("/plus/{guid}", (Guid guid) => calculatorManager.ApplyPlusAction(guid));
app.MapPost("/minus/{guid}", (Guid guid) => calculatorManager.ApplyMinusAction(guid));
app.MapPost("/equal/{guid}", (Guid guid) => calculatorManager.ApplyEqualAction(guid));
app.MapPost("/left-parentheses/{guid}", (Guid guid) => calculatorManager.ApplyLeftParentheses(guid));
app.MapPost("/right-parentheses/{guid}", (Guid guid) => calculatorManager.ApplyRightParentheses(guid));
app.MapPost("/clean-all/{guid}", (Guid guid) => calculatorManager.ApplyCleanAll(guid));

app.Run();