

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpaceRenting
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    /// Data Source=SATELLITE;Initial Catalog=SpaceRenting;Integrated Security=True
    public partial class AdminLogin : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public AdminLogin()
        {
            InitializeComponent();
        }
        string uError;
        string pError;
        private void Button_Login(object sender, RoutedEventArgs e)
        {
            if (uName.Text == "")
            {
                uError = "User Name is required!";
                uErr.Content = uError;
            }
            else
            {
                uErr.Content = "";
            }
            if (uPass.Password == "")
            {
                pError = "Password is required!";
                pErr.Content = pError;

            }
            else
            {
                pErr.Content = "";
            }

            if (uName.Text != "" && uPass.Password != "")
            {

                SqlConnection connection = new SqlConnection(@"Data Source=SATELLITE;Initial Catalog=Renting;Integrated Security=True");
                try
                {
                    connection.Open();
                    string query = "Select count(*) from [Admin_Info] where UserName='" + uName.Text + "' AND Password= '" + uPass.Password + "'";
                    SqlCommand sqlcmd = new SqlCommand(query, connection);
                    int qValue = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    if (qValue == 1)
                    {

                        AdminSelect uv = new AdminSelect();
                        uv.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No match with data!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void Button_Previous_Page(object sender, RoutedEventArgs e)
        {

            Login su = new Login();
            su.Show();
            this.Hide();
        }

    }
}



