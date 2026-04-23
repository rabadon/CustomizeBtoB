using System.Windows;

namespace Core.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExecuteMenu1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu1");
        }
        private void ExecuteMenu2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu2");
        }
        private void ExecuteMenu3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu3");
        }
        private void ExecuteMenu4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu4");
        }
    }
}