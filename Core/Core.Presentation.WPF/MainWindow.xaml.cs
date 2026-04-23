using System.Windows;
using Core.Presentation.WPF.HR.Views;

namespace Core.Presentation.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExecuteMenu1(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new EmployeeView();
        }

        private void ExecuteMenu2(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SalesView();
        }

        private void ExecuteMenu3(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SalesView();
        }

        private void ExecuteMenu4(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SalaryView();
        }
    }
}
