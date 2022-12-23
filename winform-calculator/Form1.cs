using calculator;
using System;
using web_protocol;
using winform_calculator.Buttons;

namespace winform_calculator
{
    /// <summary>
    /// main form
    /// </summary>
    public partial class Form1 : Form
    {

        private HttpClient HttpClient;
        private Guid Guid;

        public Form1()
        {
            InitializeComponent();

            HttpClient = new HttpClient();
            Guid = ServerEndpoint.CreateRequest(HttpClient);

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

        /// <summary>
        /// on button press
        /// </summary>
        /// <param name="sender">sender button</param>
        /// <param name="e">event args</param>
        private void OnMyClick(object? sender, EventArgs e)
        {
            Button button = ((Button)sender);
            string url = (string)button.Tag;
            url += $"/{Guid}";

            HttpRequestMessage requestMessage =
    new HttpRequestMessage(HttpMethod.Post, url);
            CalculatorContext calculatorContext = ServerEndpoint.SendRequest(HttpClient, requestMessage);

            ResultText.Text = calculatorContext.ResultStr;
            EquationText.Text = calculatorContext.EquationStr;
            PreTextBox.Text = calculatorContext.PreOrderStr;
            InTextBox.Text = calculatorContext.InOrderStr;
            PostTextBox.Text = calculatorContext.PostOrderStr;

        }
    }
}