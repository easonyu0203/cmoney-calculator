// See https://aka.ms/new-console-template for more information

using calculator;


ICalculator calculator = new WebCalculator();
calculator.Init();


ICalculator calculator2 = new WebCalculator();
calculator2.Init();

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


calculator2.ApplyLeftParentheses();
calculator2.ApplyNumberAction(1);
calculator2.ApplyPlusAction();
calculator2.ApplyNumberAction(2);
calculator2.ApplyRightParentheses();
calculator2.ApplyMultiplyAction();
calculator2.ApplyNumberAction(3);
calculator2.ApplyEqualAction();

Console.WriteLine(calculator2.EquationStr);
Console.WriteLine(calculator2.ResultStr);