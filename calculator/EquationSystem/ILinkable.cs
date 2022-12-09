namespace calculator.EquationSystem;

public interface ILinkable
{
    public void SetLeft(ILinkable linkable);
    public void SetRight(ILinkable linkable);
}