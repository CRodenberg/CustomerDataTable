using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System;

namespace DataGridBind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region MySqlConnection Connection
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);      
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select CustomerID, ContactName, Address, City, Phone, Email from customers where ContactName like '%A'", conn);
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



        #endregion

        private void btnloaddata_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
