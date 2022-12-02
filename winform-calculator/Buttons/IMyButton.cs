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
        public void OnPress(ICalculator calculatorController);
    }

    public class MyButton0 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyZeroAction();
        }
    }

    public class MyButton1 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(1);
        }
    }
    public class MyButton2 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(2);
        }
    }
    public class MyButton3 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(3);
        }
    }
    public class MyButton4 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(4);
        }
    }
    public class MyButton5 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(5);
        }
    }
    public class MyButton6 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(6);
        }
    }
    public class MyButton7 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(7);
        }
    }

    public class MyButton8 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(8);
        }
    }

    public class MyButton9 : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyNumberAction(9);
        }
    }

    public class MyPlusButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyPlusAction();
        }
    }
    public class MyMultiplyButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyMultiplyAction();
        }
    }

}
