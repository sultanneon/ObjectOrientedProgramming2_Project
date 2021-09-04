
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
    /// Interaction logic for AdminRemoveUser.xaml
    /// </summary>
    public partial class AdminRemoveSpace : Window
    {
        public AdminRemoveSpace()
        {
            InitializeComponent();
        }
        string spaceIdError;
        private void Button_Remove_Space(object sender, RoutedEventArgs e)
        {
            if (uSpaceID.Text == "")
            {
                spaceIdError = "User Name is required!";
                spaceIDErr.Content = spaceIdError;
            }
            else
            {
                spaceIDErr.Content = "";
            }
            if (uSpaceID.Text != "")
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = (@"Data Source=SATELLITE;Initial Catalog=Renting;Integrated Security=True");


                string sql = "DELETE FROM [Space_Info] where SpaceID = '" + uSpaceID.Text + " ' ";


                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                //AdminRemovedUser su = new AdminRemovedUser();
                //su.Show();
                //this.Hide();
                MessageBox.Show("Space removed successfully");
            }
            else
            {
                MessageBox.Show(" Space id didn't match ");
            }


        }
        private void Button_Previous_Page(object sender, RoutedEventArgs e)
        {

            AdminSelect su = new AdminSelect();
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

