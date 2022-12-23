using calculator;

namespace winform_calculator.Buttons;

/// <summary>
/// Button handle of button 4
/// </summary>
public class MyButton4 : Button, IMyButton
{
    /// <summary>
    /// on button press
    /// </summary>
    /// <param name="calculatorController">the winform calculator instance</param>
    public void OnPress(ICalculator calculatorController)
    {
        calculatorController.ApplyNumberAction(4);
    }
}