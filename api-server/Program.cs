using api_server;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo(){Title = "Calculator API", Version = "v1"});
});
WebApplication app = builder.Build();


CalculatorManager calculatorManager = new CalculatorManager();

app.MapGet("/", () => "Hello World!");
app.MapPost("/create", () => Results.Json(calculatorManager.CreateCalculator()));
app.MapPost("/0/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyZeroAction(guid)));
app.MapPost("/{num}/{guid}", (int num, Guid guid) => Results.Json(calculatorManager.ApplyNumberAction(guid, num)));
app.MapPost("/decimal/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyDecimalAction(guid)));
app.MapPost("/delete-result-str/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyDeleteResultStrAction(guid)));
app.MapPost("/clean-result-str/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyCleanResultStr(guid)));
app.MapPost("/sign/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplySignAction(guid)));
app.MapPost("/sqrt/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplySqrtAction(guid)));
app.MapPost("/multiply/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyMultiplyAction(guid)));
app.MapPost("/divide/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyDivideAction(guid)));
app.MapPost("/plus/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyPlusAction(guid)));
app.MapPost("/minus/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyMinusAction(guid)));
app.MapPost("/equal/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyEqualAction(guid)));
app.MapPost("/left-parentheses/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyLeftParentheses(guid)));
app.MapPost("/right-parentheses/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyRightParentheses(guid)));
app.MapPost("/clean-all/{guid}", (Guid guid) => Results.Json(calculatorManager.ApplyCleanAll(guid)));


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/v1/swagger.json", "Calculator API");
    });
}



app.Run();