namespace calculator.state_machine.equation;

public abstract class EquationState : State
{
    // number manipulation action
    public virtual void ApplyZeroAction()
    {
    }

    public virtual void ApplyNumberAction(int num)
    {
    }

    public virtual void ApplyDecimalAction()
    {
    }

    public virtual void ApplyDeleteResultStrAction()
    {
    }

    public virtual void ApplyCleanResultStr()
    {
    }

    // operator action
    public virtual void ApplySignAction()
    {
    }

    public virtual void ApplySqrtAction()
    {
    }

    public virtual void ApplyMultiplyAction()
    {
    } 

    public virtual void ApplyDivideAction()
    {
    } 

    public virtual void ApplyPlusAction()
    {
    } 

    public virtual void ApplyMinusAction()
    {
    } 

    public virtual decimal ApplyEqualAction()
    {
        return 0;
    } 
    

    protected EquationState(StateMachine stateMachine) : base(stateMachine)
    {
    }
}