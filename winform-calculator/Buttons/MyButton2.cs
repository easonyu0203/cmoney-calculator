using calculator;

namespace winform_calculator.Buttons;

/// <summary>
/// Button handle of button 2
/// </summary>
public class MyButton2 : Button, IMyButton
{
    /// <summary>
    /// on button press
    /// </summary>
    /// <param name="calculatorController">the winform calculator instance</param>
    public void OnPress(ICalculator calculatorController)
    {
        calculatorController.ApplyNumberAction(2);
    }
}