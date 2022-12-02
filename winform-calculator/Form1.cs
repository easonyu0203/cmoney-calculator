using calculator;

namespace winform_calculator
{
    public partial class Form1 : Form
    {
        private ICalculatorController _calculatorController;
        private ICalculatorDisplay _calculatorDisplay;

        public Form1(ICalculatorController calculatorController, ICalculatorDisplay calculatorDisplay)
        {
            InitializeComponent();
            _calculatorController= calculatorController;
            _calculatorDisplay= calculatorDisplay;  
            
        }
    }
}