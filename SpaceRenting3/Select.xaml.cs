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
    /// Interaction logic for Select.xaml
    /// </summary>
    public partial class Select : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Select()
        {
            InitializeComponent();
        }
        private void Button_Add_Space(object sender, RoutedEventArgs e)
        {
            AddSpace asp = new AddSpace();
            asp.Show();
            this.Hide();
        }
        private void Button_Watch_Available_Space(object sender, RoutedEventArgs e)
        {
            SearchSpace ssp = new SearchSpace();
            ssp.Show();
            this.Hide();
        }

        private void Button_Logout(object sender, RoutedEventArgs e)
        {

            Login su = new Login();
            su.Show();
            this.Hide();
        }
        private void Button_Help(object sender, RoutedEventArgs e)
        {

            Help su = new Help();
            su.Show();
            this.Hide();
        }
    }
}

