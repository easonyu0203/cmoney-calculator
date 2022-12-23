using calculator;

namespace winform_calculator
{
    /// <summary>
    /// main program
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ICalculator calculator= new Calculator();
            calculator.Init();
            Application.Run(new Form1(calculator));
        }
    }
}