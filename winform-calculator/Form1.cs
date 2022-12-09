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
        }

        private void OnMyClick(object? sender, EventArgs e)
        {
            ((IMyButton)sender).OnPress(_calculator);

        }
    }
}