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
            Application.Run(new frm_Principal());
        }
    }
}