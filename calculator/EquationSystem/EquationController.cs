using calculator.EquationSystem.Elements;

namespace calculator.EquationSystem;

/// <summary>
/// Equation main control class, the equation should be manipulate and called by here
/// </summary>
public class EquationController
{
    /// <summary>
    /// stack of all sub equation state machine
    /// </summary>
    private Stack<SubEquationStateMachine> AllEquationStateMachines;

    public EquationController()
    {
        AllEquationStateMachines = new Stack<SubEquationStateMachine>();
        AllEquationStateMachines.Push(new SubEquationStateMachine());
        AllEquationStateMachines.Peek().Init();
    }

    /// <summary>
    /// create a sub equation
    /// </summary>
    public void AddLeftParentheses()
    {
        AllEquationStateMachines.Push(new SubEquationStateMachine());
        AllEquationStateMachines.Peek().Init();
    }
    
    /// <summary>
    /// finish (pop out) sub equation
    /// </summary>
    public void AddRightParentheses()
    {
        Node node = AllEquationStateMachines.Pop().GetTree();
        AllEquationStateMachines.Peek().AddNode(node);
    }
    
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    /// <param name="value"></param>
    public void AddOperand(decimal value)
    {
        AllEquationStateMachines.Peek().AddOperand(value);
    }
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddPlusOperator()
    {
        AllEquationStateMachines.Peek().AddPlusOperator();
    }
    
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddMinusOperator()
    {
        AllEquationStateMachines.Peek().AddMinusOperator();
    }

    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddMultiplyOperator()
    {
        AllEquationStateMachines.Peek().AddMultiplyOperator();
    }
    
    /// <summary>
    ///  add operand to deepest sub equation
    /// </summary>
    public void AddDivideOperator()
    {
        AllEquationStateMachines.Peek().AddDivideOperator();
    }

    /// <summary>
    /// calculate the equation
    /// </summary>
    /// <returns>
    /// result of equation, and string representation of traversal of preorder, inorder, postorder
    /// </returns>
    public (decimal resultValue, string preOrder, string inOrder, string postOrder) CalculateResult()
    {
        Node root = AllEquationStateMachines.Peek().GetTree();
        string preOrder = root.PreOrderTraverse();
        string inOrder = root.InorderTraverse();
        string postOrder = root.PostOrderTraverse();
        decimal resultValue = root.CalculateValue();

        return (resultValue, preOrder, inOrder, postOrder);
    }
    
}