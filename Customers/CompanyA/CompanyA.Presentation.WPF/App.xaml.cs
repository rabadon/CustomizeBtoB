using System.Windows;

namespace CompanyA.Presentation.WPF
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var window = new Core.Presentation.WPF.MainWindow();
            window.Show();
        }
    }
}
