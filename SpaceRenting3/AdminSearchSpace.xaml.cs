

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
    public partial class AdminSearchSpace : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public AdminSearchSpace()
        {
            InitializeComponent();
        }

        string sError;
        private void Button_Search_Space(object sender, RoutedEventArgs e)
        {

            if (uSpaceID.Text == "")
            {
                sError = "Password is required!";
                spaceIDErr.Content = sError;
            }
            else
            {
                spaceIDErr.Content = "";
            }
            if (uSpaceID.Text != "")
            {


                string spaceID = uSpaceID.Text.ToString();
                AdminSearchedSpace s = new AdminSearchedSpace(spaceID);
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





