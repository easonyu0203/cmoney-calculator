// See https://aka.ms/new-console-template for more information

using calculator;
// using calculator.EquationSystem;
//
// Equation equation = new Equation();
//
// equation.AddOperand(new Operand(2));
// equation.AddLowBinaryOperator(new PlusOperator());
// equation.AddOperand(new Operand(4));
// equation.AddHighBinaryOperator(new MultiplyOperator());
// equation.AddOperand(new Operand(3));
// equation.AddLowBinaryOperator(new PlusOperator());
// equation.AddOperand(new Operand(1));
// Console.WriteLine(equation);
// Console.WriteLine(equation.Calculate());

Calculator calculator = new Calculator();

calculator.ApplyNumberAction(1);
calculator.ApplyNumberAction(6);
calculator.ApplySqrtAction();
calculator.ApplyPlusAction();
calculator.ApplyNumberAction(2);
// calculator.ApplyPlusAction();
// calculator.ApplyNumberAction(3);
// calculator.ApplyDivideAction();
// calculator.ApplyNumberAction(4);
// calculator.ApplyPlusAction();
// calculator.ApplyNumberAction(4);
// calculator.ApplySignAction();

calculator.ApplySignAction();
calculator.ApplyEqualAction();

Console.WriteLine(calculator.EquationStr);
Console.WriteLine(calculator.ResultStr);