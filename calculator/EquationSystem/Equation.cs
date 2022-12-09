using System.Text;

namespace calculator.EquationSystem;

public class Equation
{
    private List<BinaryOperator> _highBinaryOperator;
    private List<BinaryOperator> _lowBinaryOperators;
    private List<BinaryOperator> _allBinaryOperators;
    private List<UnaryExpression> _operands;
    /// <summary>
    /// this is for output equation, we store all element in equation as an array
    /// </summary>
    private List<ILinkable> _elements;
    private string _suffixStr;

    public Equation()
    {
        _highBinaryOperator = new List<BinaryOperator>();
        _lowBinaryOperators = new List<BinaryOperator>();
        _allBinaryOperators = new List<BinaryOperator>();
        _elements = new List<ILinkable>();
        _operands = new List<UnaryExpression>();
        _suffixStr = "";
    }

    public void SetSuffixStr(string str)
    {
        _suffixStr = str;
    }

    public void AddOperand(UnaryExpression unaryExpression)
    {
        _operands.Add(unaryExpression);
        _elements.Add(unaryExpression);
    }

    public void AddLowBinaryOperator(BinaryOperator lowBinaryOperator)
    {
        _allBinaryOperators.Add(lowBinaryOperator);
        _lowBinaryOperators.Add(lowBinaryOperator);
        _elements.Add(lowBinaryOperator);
    }

    public void AddHighBinaryOperator(BinaryOperator highBinaryOperator)
    {
        _allBinaryOperators.Add(highBinaryOperator);
        _highBinaryOperator.Add(highBinaryOperator);
        _elements.Add(highBinaryOperator);
    }

    /// <summary>
    /// calculate equation result
    /// </summary>
    /// <returns></returns>
    public decimal Calculate()
    {
        // link up
        for (int i = 0; i < _elements.Count - 1; i++)
        {
            ILinkable left = _elements[i];
            ILinkable right = _elements[i + 1];
            left.SetRight(right);
            right.SetLeft(left);
        }
        
        // calculate high, low Operators value
        UnaryExpression resultUnaryExpression = new UnaryExpression(1111);
        foreach (List<BinaryOperator> binaryOperators in new []{_highBinaryOperator, _lowBinaryOperators})
        {
            foreach (BinaryOperator binaryOperator in binaryOperators)
            {
                decimal value = binaryOperator.Calculate();
                resultUnaryExpression = new UnaryExpression(value);
                BinaryOperator? left = binaryOperator.LeftUnaryExpression.LeftBinaryOperator;
                BinaryOperator? right = binaryOperator.RightUnaryExpression.RightBinaryOperator;
                left?.SetRight(resultUnaryExpression);
                right?.SetLeft(resultUnaryExpression);
            }
        }

        return resultUnaryExpression.Value;
    }

    public override string ToString()
    {
        return string.Join(" ", _elements) + " " + _suffixStr;
    }
}