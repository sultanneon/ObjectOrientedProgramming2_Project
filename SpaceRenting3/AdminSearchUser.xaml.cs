

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
    public partial class AdminSearchUser : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public AdminSearchUser()
        {
            InitializeComponent();
        }

        string sError;
        private void Button_Search_User(object sender, RoutedEventArgs e)
        {
           
            if (uUserID.Text == "")
            {
                sError = "User ID is required!";
                userIDErr.Content = sError;
            }
            else
            {
                userIDErr.Content = "";
            }
            if ( uUserID.Text != "")
            {

               
                string userID = uUserID.Text.ToString();
                AdminSearchedUser s = new AdminSearchedUser( userID);
                s.Show();
                this.Hide();


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




