using calculator;
using winform_calculator.Buttons;

namespace winform_calculator
{
    public partial class Form1 : Form
    {
        private ICalculator _calculator;

        public Form1(ICalculator calculatorController)
        {
            InitializeComponent();
            _calculator = calculatorController;

            _calculator.UpdateEvent += () =>
            {
                ResultText.Text = _calculator.ResultStr;
                EquationText.Text = _calculator.EquationStr;
            };

            Button0.Click += (o, e) =>
            {
                ((IMyButton)o).OnPress(_calculator);
            };
        }
    }
}