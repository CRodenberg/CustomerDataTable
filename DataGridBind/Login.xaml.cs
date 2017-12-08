using System.Windows;


namespace DataGridBind
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(userTxt.Text == "username")
            {
                MainWindow dataTable = new MainWindow();
                this.Hide();
                dataTable.Show();
                
            }
            else
            {
                MessageBox.Show("Please enter a correct username and password.");
            }
            
        }
    }
}
