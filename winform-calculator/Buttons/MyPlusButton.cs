using calculator;

namespace winform_calculator.Buttons;

/// <summary>
/// Button handle of button zero
/// </summary>
public class MyPlusButton : Button, IMyButton
{
    /// <summary>
    /// on button press
    /// </summary>
    /// <param name="calculatorController">the winform calculator instance</param>
    public void OnPress(ICalculator calculatorController)
    {
        calculatorController.ApplyPlusAction();
    }
}