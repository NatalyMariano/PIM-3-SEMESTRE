namespace PIM_3º_SEMESTRE
{
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
            // Instanciando a lista de feedbacks

            ListaDeFeedback instance = ListaDeFeedback.Instance;

            ApplicationConfiguration.Initialize();

            //add dados fakes como feedbacks
            ListaDeFeedback.Instance.AdicionarFeedback(1, 3);
            ListaDeFeedback.Instance.AdicionarFeedback(1, 4);

            ListaDeFeedback.Instance.AdicionarFeedback(2, 5);
            ListaDeFeedback.Instance.AdicionarFeedback(2, 1);

            ListaDeFeedback.Instance.AdicionarFeedback(3, 1);
            ListaDeFeedback.Instance.AdicionarFeedback(3, 1);



            Application.Run(new frm_Home());
        }
    }
}