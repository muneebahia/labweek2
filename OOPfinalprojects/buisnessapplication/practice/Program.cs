using practice.DL;

namespace practice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            productDL.readproductdatafromfile();
            feedbackDL.readfeedbackdatafromfile();
            discountDL.readDiscountdatafromfile();
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}