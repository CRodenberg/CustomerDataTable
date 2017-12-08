using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DataGridBind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MaintenanceWindow edit = new MaintenanceWindow();
        #region MySqlConnection Connection
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        public MainWindow()
        {
            InitializeComponent();
            loadData();
        }

        #endregion
        public void loadData()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select CustomerID, ContactName, Address, City, Phone from customers", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                dataGridCustomers.DataContext = ds;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnloaddata_Click(object sender, RoutedEventArgs e)
        {
            edit.Show();
            edit.Owner = this;
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            loadData();
        }
    }
}
