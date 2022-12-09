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

    public class MyDecimalButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyDecimalAction();
        }
    }

    public class MySignButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplySignAction();
        }
    }

    public class MySqrtButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplySqrtAction();
        }
    }

    public class MyPlusButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyPlusAction();
        }
    }
    public class MyMinusButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyMinusAction();
        }
    }
    public class MyMultiplyButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyMultiplyAction();
        }
    }

    public class MyDivideButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyDivideAction();
        }
    }

    public class MyDeleteButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyDeleteResultStrAction();
        }
    }

    public class MyEqualButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyEqualAction();
        }
    }

    public class MyCEButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyCleanResultStr();
        }
    }

    public class MyCButton : Button, IMyButton
    {
        public void OnPress(ICalculator calculatorController)
        {
            calculatorController.ApplyCleanAll();
        }
    }

}
