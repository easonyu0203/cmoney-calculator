using calculator.EquationSystem.Elements;
using calculator.EquationSystem.States;
using calculator.state_machine;

namespace calculator.EquationSystem;

/// <summary>
/// equation state machine which dont consider parentheses
/// </summary>
public class SubEquationStateMachine : StateMachine
{
    /// <summary>
    /// sequencial stack of operator
    /// </summary>
    public Stack<Node> OperatorStack;
    /// <summary>
    /// node (expression, operand) stack wait to be connect with operator
    /// </summary>
    public Stack<Node> OutputNodes;

    /// <summary>
    /// current state
    /// </summary>
    private SubEquationState CurrentSubEquationState => (SubEquationState)CurrentState;

    public SubEquationStateMachine()
    {
        OperatorStack = new Stack<Node>();
        OutputNodes = new Stack<Node>();
    }

    protected override State GetInitState()
    {
        return new EmptyStackState(this);
    }

    /// <summary>
    /// add raw node to output nodes
    /// </summary>
    /// <param name="node">node</param>
    public void AddNode(Node node)
    {
        OutputNodes.Push(node);
    }

    /// <summary>
    /// add an operand
    /// </summary>
    /// <param name="value"></param>
    public void AddOperand(decimal value)
    {
        OutputNodes.Push(new Operand(value));
    }

    /// <summary>
    /// add plus operator to sub equation
    /// </summary>
    public void AddPlusOperator()
    {
        CurrentSubEquationState.AddLowOperator(new PlusOperator());
    }
    
    /// <summary>
    /// add minus operator to sub equation
    /// </summary>
    public void AddMinusOperator()
    {
        CurrentSubEquationState.AddLowOperator(new MinusOperator());
    }

    /// <summary>
    /// add multiply operator to sub equation
    /// </summary>
    public void AddMultiplyOperator()
    {
        CurrentSubEquationState.AddHighOperator(new MultiplyOperator());
    }
    
    /// <summary>
    /// add divide operator to sub equation
    /// </summary>
    public void AddDivideOperator()
    {
        CurrentSubEquationState.AddHighOperator(new DivideOperator());
    }

    /// <summary>
    /// make the last operator in stack as node(expression)
    /// </summary>
    public Node CombineLastOperator()
    {
        Node node = OperatorStack.Pop();
        node.Right = OutputNodes.Pop();
        node.Left = OutputNodes.Pop();
        OutputNodes.Push(node);
        return node;
    }

    /// <summary>
    /// make all operator in stack as node(expression)
    /// </summary>
    public Node CombineAllOperator()
    {
        Node node = new Operand(1111);
        int cnt = OperatorStack.Count;
        for (int i = 0; i < cnt; i++)
        {
            node = CombineLastOperator();
        }

        return node;
    }

    /// <summary>
    /// should only call when finish input operator and operand, this get
    /// the tree of this expression
    /// </summary>
    /// <returns>tree of this expression</returns>
    public Node GetTree()
    {
        return CombineAllOperator();
    }
}