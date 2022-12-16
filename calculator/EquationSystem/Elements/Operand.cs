namespace calculator.EquationSystem.Elements;

public class Operand : Node
{
    private readonly decimal _value;

    public Operand(decimal value)
    {
        _value = value;
    }

    /// <summary>
    /// value is the value of operand
    /// </summary>
    /// <returns>value</returns>
    public override decimal CalculateValue()
    {
        return _value;
    }

    /// <summary>
    /// just return itself when traver
    /// </summary>
    /// <returns>string representation of itself</returns>
    public override string InorderTraverse()
    {
        return $"{this}";
    }
    
    /// <summary>
    /// just return itself when traver
    /// </summary>
    /// <returns>string representation of itself</returns>
    public override string PreOrderTraverse()
    {
        return $"{this}";
    }
    
    /// <summary>
    /// just return itself when traver
    /// </summary>
    /// <returns>string representation of itself</returns>
    public override string PostOrderTraverse()
    {
        return $"{this}";
    }

    /// <summary>
    /// to string value
    /// </summary>
    /// <returns>string representation of value </returns>
    public override string ToString()
    {
        return $"{_value}";
    }
    
    
}