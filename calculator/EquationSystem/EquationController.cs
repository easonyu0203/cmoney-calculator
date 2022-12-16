using calculator.EquationSystem.Elements;

namespace calculator.EquationSystem;

/// <summary>
/// Equation main control class, the equation should be manipulate and called by here
/// </summary>
public class EquationController
{
    private Stack<SubEquationStateMachine> _allEquationStateMachines;

    public EquationController()
    {
        _allEquationStateMachines = new Stack<SubEquationStateMachine>();
        _allEquationStateMachines.Push(new SubEquationStateMachine());
        _allEquationStateMachines.Peek().Init();
    }

    /// <summary>
    /// create a sub equation
    /// </summary>
    public void AddLeftParentheses()
    {
        _allEquationStateMachines.Push(new SubEquationStateMachine());
        _allEquationStateMachines.Peek().Init();
    }
    
    /// <summary>
    /// finish (pop out) sub equation
    /// </summary>
    public void AddRightParentheses()
    {
        Node node = _allEquationStateMachines.Pop().GetTree();
        _allEquationStateMachines.Peek().AddNode(node);
    }
    
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    /// <param name="value"></param>
    public void AddOperand(decimal value)
    {
        _allEquationStateMachines.Peek().AddOperand(value);
    }
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddPlusOperator()
    {
        _allEquationStateMachines.Peek().AddPlusOperator();
    }
    
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddMinusOperator()
    {
        _allEquationStateMachines.Peek().AddMinusOperator();
    }

    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddMultiplyOperator()
    {
        _allEquationStateMachines.Peek().AddMultiplyOperator();
    }
    
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddDivideOperator()
    {
        _allEquationStateMachines.Peek().AddDivideOperator();
    }

    /// <summary>
    /// calculate the equation
    /// </summary>
    /// <returns>
    /// result of equation, and string representation of traversal of preorder, inorder, postorder
    /// </returns>
    public (decimal resultValue, string preOrder, string inOrder, string postOrder) CalculateResult()
    {
        Node root = _allEquationStateMachines.Peek().GetTree();
        string preOrder = root.PreOrderTraverse();
        string inOrder = root.InorderTraverse();
        string postOrder = root.PostOrderTraverse();
        decimal resultValue = root.CalculateValue();

        return (resultValue, preOrder, inOrder, postOrder);
    }
    
}