using calculator;

namespace winform_calculator.Buttons
{
    /// <summary>
    /// my button to polymorphism
    /// </summary>
    internal interface IMyButton
    {
        /// <summary>
        /// Call when Press
        /// </summary>
        public void OnPress(ICalculator calculatorController);
    }


}