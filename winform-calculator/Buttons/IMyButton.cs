using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_calculator.Buttons
{
    /// <summary>
    /// my button to polymophy
    /// </summary>
    internal interface IMyButton
    {
        /// <summary>
        /// Call when Press
        /// </summary>
        public void OnPress(ICalculatorController calculatorController);
    }

    public class MyButton0 : IMyButton
    {
        public void OnPress(ICalculatorController calculatorController)
        {
            calculatorController.ApplyZeroAction();
        }
    }

    public class MyButton1 : IMyButton
    {
        public void OnPress(ICalculatorController calculatorController)
        {
            calculatorController.ApplyNumberAction(1);
        }
    }
}
