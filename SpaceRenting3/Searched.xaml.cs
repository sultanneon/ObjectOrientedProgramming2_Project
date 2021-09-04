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
    /// Interaction logic for Searched.xaml
    /// </summary>
    public partial class Searched : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Searched(string userLocation,string userSpaceType)
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection(@"Data Source=SATELLITE;Initial Catalog=Renting;Integrated Security=True");
            try
            {
                connection.Open();
                string query = "Select Username,Location,PhoneNumber,SpaceType,Cost from [Space_Info] where Location='" + userLocation + "' AND SpaceType= '" + userSpaceType + "'";
                SqlCommand sqlcmd = new SqlCommand(query, connection);
                sqlcmd.CommandType = System.Data.CommandType.Text;

                System.Data.DataTable dt = new System.Data.DataTable("Space_Info");
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                datagrid1.ItemsSource = dt.DefaultView;
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
        private void Button_Previous_Page(object sender, RoutedEventArgs e)
        {

            SearchSpace su = new SearchSpace();
            su.Show();
            this.Hide();
        }
        private void Button_Logout(object sender, RoutedEventArgs e)
        {

            Login su = new Login();
            su.Show();
            this.Hide();
        }
    }
}
