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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpaceRenting
{
    /// <summary>
    /// Interaction logic for AdminRemovedUser.xaml
    /// </summary>
    public partial class AdminRemovedUser : Window
    {
        public AdminRemovedUser()
        {
            InitializeComponent();
        }
        private void Button_Previous_Page(object sender, RoutedEventArgs e)
        {

            AdminRemoveUser su = new AdminRemoveUser();
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
