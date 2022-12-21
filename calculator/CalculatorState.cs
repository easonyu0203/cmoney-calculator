using calculator.state_machine;
using calculator.StateDesign;

namespace calculator;

/// <summary>
/// Base state of calculator state machine
/// </summary>
public abstract class CalculatorState : State
{
    // number manipulation action
    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyZeroAction()
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyNumberAction(int num)
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyDecimalAction()
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyDeleteResultStrAction()
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyCleanResultStr()
    {
    }

    // operator action
    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplySignAction()
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplySqrtAction()
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyMultiplyAction()
    {
    } 

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyDivideAction()
    {
    } 

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyPlusAction()
    {
    } 

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyMinusAction()
    {
    }

    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyLeftParentheses(){}
    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyRightParentheses(){}
    
    /// <summary>
    /// apply decimal action
    /// </summary>
    public virtual void ApplyEqualAction(){}
    

    protected CalculatorState(Calculator calculator) : base(calculator)
    {
    }
}