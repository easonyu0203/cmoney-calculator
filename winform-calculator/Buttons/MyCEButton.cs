using calculator;

namespace winform_calculator.Buttons;

/// <summary>
/// Button handle of button clean result string
/// </summary>
public class MyCEButton : Button, IMyButton
{
    /// <summary>
    /// on button press
    /// </summary>
    /// <param name="calculatorController">the winform calculator instance</param>
    public void OnPress(ICalculator calculatorController)
    {
        calculatorController.ApplyCleanResultStr();
    }
}