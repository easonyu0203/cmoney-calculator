// See https://aka.ms/new-console-template for more information

using calculator;
using calculator.EquationSystem;
using calculator.EquationSystem.Elements;
using console_playground;


WebCalculator calculator = new WebCalculator();
calculator.ApplyLeftParentheses();
calculator.ApplyNumberAction(1);
calculator.ApplyPlusAction();
calculator.ApplyNumberAction(2);
calculator.ApplyRightParentheses();
calculator.ApplyMultiplyAction();
calculator.ApplyNumberAction(3);
calculator.ApplyEqualAction();

Console.WriteLine(calculator.EquationStr);
Console.WriteLine(calculator.ResultStr);