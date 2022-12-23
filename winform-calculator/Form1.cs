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
            
            Button0.Tag = (object)ServerEndpoint.ZeroUrl  + $"/{Guid}";
            button1.Tag = (object)ServerEndpoint.NumberUrl  + $"/1/{Guid}";
            button2.Tag = (object)ServerEndpoint.NumberUrl  + $"/2/{Guid}";
            button3.Tag = (object)ServerEndpoint.NumberUrl  + $"/3/{Guid}";
            button4.Tag = (object)ServerEndpoint.NumberUrl  + $"/4/{Guid}";
            button5.Tag = (object)ServerEndpoint.NumberUrl  + $"/5/{Guid}";
            button6.Tag = (object)ServerEndpoint.NumberUrl  + $"/6/{Guid}";
            button7.Tag = (object)ServerEndpoint.NumberUrl  + $"/7/{Guid}";
            button8.Tag = (object)ServerEndpoint.NumberUrl  + $"/8/{Guid}";
            button9.Tag = (object)ServerEndpoint.NumberUrl  + $"/9/{Guid}";
            SignButton.Tag = (object)ServerEndpoint.SignUrl  + $"/{Guid}";
            SqrtButton.Tag = (object)ServerEndpoint.SqrtUrl  + $"/{Guid}";
            PlusButton.Tag = (object)ServerEndpoint.PlusUrl  + $"/{Guid}";
            MinusButton.Tag = (object)ServerEndpoint.MinusUrl  + $"/{Guid}";
            MultiplyButton.Tag = (object)ServerEndpoint.MultiplyUrl  + $"/{Guid}";
            DivideButton.Tag = (object)ServerEndpoint.DivideUrl  + $"/{Guid}";
            DeleteButton.Tag = (object)ServerEndpoint.DeleteResultStrUrl  + $"/{Guid}";
            CEButton.Tag = (object)ServerEndpoint.CleanResultStrUrl  + $"/{Guid}";
            CButton.Tag = (object)ServerEndpoint.CleanAllUrl  + $"/{Guid}";
            DecimalButton.Tag = (object)ServerEndpoint.DecimalUrl  + $"/{Guid}";
            EqualButton.Tag = (object)ServerEndpoint.EqualUrl  + $"/{Guid}";
            LeftButton.Tag = (object)ServerEndpoint.LeftParenthesesUrl  + $"/{Guid}";
            RightButton.Tag = (object)ServerEndpoint.RightParenthesesUrl  + $"/{Guid}";

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