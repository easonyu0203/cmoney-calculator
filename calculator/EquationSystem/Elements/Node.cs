namespace calculator.EquationSystem.Elements;

/// <summary>
/// a node in tree
/// </summary>
public abstract class Node
{
    /// <summary>
    /// the value of the node, which calculate all it decedent
    /// </summary>
    /// <returns></returns>
    public abstract decimal CalculateValue();

    /// <summary>
    /// left node
    /// </summary>
    public Node? Left;

    /// <summary>
    /// right node
    /// </summary>
    public Node? Right;

    /// <summary>
    /// default to string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return "[none str]";
    }

    /// <summary>
    /// an inorder traverse of the as this node as root
    /// </summary>
    /// <returns>string of traverse</returns>
    public virtual string InorderTraverse()
    {
        return $"{Left!.InorderTraverse()} {this} {Right!.InorderTraverse()}";
    }
    
    /// <summary>
    /// an PreOrder traverse of the as this node as root
    /// </summary>
    /// <returns>string of traverse</returns>
    public virtual string PreOrderTraverse()
    {
        return $"{this} {Left!.PreOrderTraverse()} {Right!.PreOrderTraverse()}";
    }
    
    /// <summary>
    /// an PostOrder traverse of the as this node as root
    /// </summary>
    /// <returns>string of traverse</returns>
    public virtual string PostOrderTraverse()
    {
        return $"{Left!.InorderTraverse()} {Right!.InorderTraverse()} {this}";
    }
}