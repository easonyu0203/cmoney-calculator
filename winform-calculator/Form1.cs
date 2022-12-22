using calculator;
using winform_calculator.Buttons;

namespace winform_calculator
{
    /// <summary>
    /// main form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// calculator for the form
        /// </summary>
        private ICalculator Calculator;

        public Form1(ICalculator calculatorController)
        {
            InitializeComponent();
            Calculator = calculatorController;

            Calculator.UpdateEvent += () =>
            {
                ResultText.Text = Calculator.ResultStr;
                EquationText.Text = Calculator.EquationStr;
                PreTextBox.Text = Calculator.PreOrderStr;
                InTextBox.Text = Calculator.InOrderStr;
                PostTextBox.Text = Calculator.PostOrderStr;
            };

            Button0.Click += OnMyClick;
            button1.Click += OnMyClick;
            button2.Click += OnMyClick;
            button3.Click += OnMyClick;
            button4.Click += OnMyClick;
            button5.Click += OnMyClick;
            button6.Click += OnMyClick;
            button7.Click += OnMyClick;
            button8.Click += OnMyClick;
            button9.Click += OnMyClick;
            SignButton.Click += OnMyClick;
            SqrtButton.Click += OnMyClick;
            PlusButton.Click += OnMyClick;
            MinusButton.Click += OnMyClick;
            MultiplyButton.Click += OnMyClick;
            DivideButton.Click += OnMyClick;
            DeleteButton.Click += OnMyClick;
            CEButton.Click += OnMyClick;
            CButton.Click += OnMyClick;
            DecimalButton.Click += OnMyClick;
            EqualButton.Click += OnMyClick;
            LeftButton.Click += OnMyClick;
            RightButton.Click += OnMyClick;
        }

        private void OnMyClick(object? sender, EventArgs e)
        {
            ((IMyButton)sender).OnPress(Calculator);

        }
    }
}