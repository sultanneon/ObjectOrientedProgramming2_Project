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
    /// Interaction logic for AdminSelect.xaml
    /// </summary>
    public partial class AdminSelect : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public AdminSelect()
        {
            InitializeComponent();
        }
        private void Button_Search_User(object sender, RoutedEventArgs e)
        {
            AdminSearchUser su = new AdminSearchUser();
            su.Show();
            this.Hide();
        }
        private void Button_All_User(object sender, RoutedEventArgs e)
        {
            AdminAllUser su = new AdminAllUser();
            su.Show();
            this.Hide();
        }
        private void Button_Remove_User(object sender, RoutedEventArgs e)
        {
            AdminRemoveUser su = new AdminRemoveUser();
            su.Show();
            this.Hide();
        }
        private void Button_Search_Space(object sender, RoutedEventArgs e)
        {
            AdminSearchSpace su = new AdminSearchSpace();
            su.Show();
            this.Hide();
        }
        private void Button_All_Space(object sender, RoutedEventArgs e)
        {
            AdminAllSpace su = new AdminAllSpace();
            su.Show();
            this.Hide();
        }
        private void Button_Remove_Space(object sender, RoutedEventArgs e)
        {
            AdminRemoveSpace su = new AdminRemoveSpace();
            su.Show();
            this.Hide();
        }
        private void Button_Logout(object sender, RoutedEventArgs e)
        {

            Login su = new Login();
            su.Show();
            this.Hide();
        }
        private void Button_Previous_Page(object sender, RoutedEventArgs e)
        {

            AdminLogin su = new AdminLogin();
            su.Show();
            this.Hide();
        }
    }
}
