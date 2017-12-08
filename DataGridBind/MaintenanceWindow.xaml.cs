using System;
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace DataGridBind
{
    /// <summary>
    /// Interaction logic for MaintenanceWindow.xaml
    /// </summary>
    public partial class MaintenanceWindow : Window
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        public MaintenanceWindow()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(customerid.Text != string.Empty)
            {
                try
                {
                    if (MessageBox.Show("Do you wish to Delete this Customer?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        conn.Open();

                        String query = ("Delete from customers where CustomerID = '" + customerid.Text + "';");

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataReader myReader2;

                        myReader2 = cmd.ExecuteReader();

                        ((MainWindow)this.Owner).loadData();

                        conn.Close();
                    }
                    else
                    {
                    
                    }
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
            else
            {
                MessageBox.Show("Please enter a Customer ID");
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (customerid.Text != string.Empty && nametxt.Text != string.Empty && addresstxt.Text != string.Empty && citytxt.Text != string.Empty && ziptxt.Text != string.Empty)
            {
                try
                {
                    if (MessageBox.Show("Do you wish to Update this Customer?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        conn.Open();

                        String query = "update company.customers set ContactName ='" + nametxt.Text + "', Address ='" + addresstxt.Text + "', PostalCode ='" + ziptxt.Text + "', Phone = '" + phonetxt.Text + "', City ='" + citytxt.Text + "' where CustomerID = '" + customerid.Text + "';";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataReader myReader2;

                        myReader2 = cmd.ExecuteReader();

                        ((MainWindow)this.Owner).loadData();

                        conn.Close();
                    }
                    else
                    {

                    }
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
            else
            {
                MessageBox.Show("Please enter all fields or press Get Customer to update a new customer");
            }
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Exit the Customer Maintenance Window?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            if (customerid.Text != string.Empty && nametxt.Text != string.Empty && addresstxt.Text != string.Empty && citytxt.Text != string.Empty && ziptxt.Text != string.Empty)
            {
                try
                {
                    if (MessageBox.Show("Do you wish to Insert this Customer?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        conn.Open();

                        String query = "insert into customers (CustomerId, ContactName, Address, City, PostalCode, Phone, CompanyName, Email) VALUES ('" + customerid.Text + "', '" + nametxt.Text + "', '" + addresstxt.Text + "', '" +
                            citytxt.Text + "', '" + ziptxt.Text + "', '" + phonetxt.Text + "', 'None', 'none@email.com');";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataReader myReader2;

                        myReader2 = cmd.ExecuteReader();

                        ((MainWindow)this.Owner).loadData();

                        conn.Close();
                    }
                    else
                    {

                    }
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
            else
            {
                MessageBox.Show("Please enter all fields to insert a new customer");
            }
        }

        private void Button_Click_Get(object sender, RoutedEventArgs e)
        {
            if (customerid.Text != string.Empty)
            {
                try
                {

                    conn.Open();
                    String query = "Select ContactName, Address, City, Phone, PostalCode from customers where customerID = '" + customerid.Text + "'";
                    DataTable tbl = new DataTable();
                    MySqlDataReader myReader = null;
                    MySqlCommand myCommand = new MySqlCommand(query, conn);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        nametxt.Text = (myReader["ContactName"].ToString());
                        addresstxt.Text = (myReader["Address"].ToString());
                        citytxt.Text = (myReader["City"].ToString());
                        phonetxt.Text = (myReader["Phone"].ToString());
                        ziptxt.Text = (myReader["PostalCode"].ToString());
                    }
                    conn.Close();
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
            else
            {
                MessageBox.Show("Please enter a Customer ID");
            }
            
        }
    }
}
