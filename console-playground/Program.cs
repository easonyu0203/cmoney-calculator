// See https://aka.ms/new-console-template for more information

using calculator;
using calculator.EquationSystem;
using calculator.EquationSystem.Elements;


Calculator calculator = new Calculator();
calculator.Init();

// calculator.ApplyLeftParentheses();
// calculator.ApplyNumberAction(1);
// calculator.ApplyPlusAction();
// calculator.ApplyNumberAction(2);
// calculator.ApplyRightParentheses();
// calculator.ApplyMultiplyAction();
// calculator.ApplyNumberAction(3);
// calculator.ApplyPlusAction();
// calculator.ApplyNumberAction(4);
// calculator.ApplyEqualAction();

calculator.ApplyNumberAction(1);
calculator.ApplyPlusAction();
calculator.ApplyNumberAction(2);
calculator.ApplyMultiplyAction();
calculator.ApplyLeftParentheses();
calculator.ApplyNumberAction(3);
calculator.ApplyPlusAction();
calculator.ApplyNumberAction(4);
calculator.ApplyRightParentheses();
calculator.ApplyEqualAction();

Console.WriteLine(calculator.EquationStr);
Console.WriteLine(calculator.ResultStr);