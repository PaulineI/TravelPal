using System.Windows;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername1.Text;
            string password = txtPassword1.Password;

            UserManager.AddUser(username, password);

            Close();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            // Temporary comment 
        }


    }
}
