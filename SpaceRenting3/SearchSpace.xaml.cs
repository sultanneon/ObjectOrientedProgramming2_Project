//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Shapes;

//namespace SpaceRenting
//{
//    /// <summary>
//    /// Interaction logic for SearchSpace.xaml
//    /// </summary>
//    public partial class SearchSpace : Window
//    {
//        public SearchSpace()
//        {
//            InitializeComponent();
//        }
//    }
//}

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
    public partial class SearchSpace : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public SearchSpace()
        {
            InitializeComponent();

            string[] spacetype = new string[3];
            spacetype[0] = "Rooftop";
            spacetype[1] = "Parking";
            spacetype[2] = "Land";

            cmbSpaceType.ItemsSource = spacetype;


        }
        string lError;
        string spaceTypeError;

        private void Search_Space(object sender, RoutedEventArgs e)
        {
            if (uLocation.Text == "")
            {
                lError = "Location is required!";
                locationErr.Content = lError;
            }
            else
            {
                locationErr.Content = "";
            }
            string SPACETYPE = cmbSpaceType.SelectedItem.ToString();
            if (SPACETYPE == "")
            {
                spaceTypeError = "Space type is required!";
                spaceTypeErr.Content = spaceTypeError;
            }
            else
            {
                spaceTypeErr.Content = "";
            }
            if (uLocation.Text != "" && SPACETYPE != "" )
            {
               

                string userLocation = uLocation.Text.ToString();
               

                    string userSpaceType = cmbSpaceType.SelectedItem.ToString();
                Searched s = new Searched(userLocation, userSpaceType);
                    s.Show();
                    this.Hide();
           

            }
        }
        private void Button_Previous_Page(object sender, RoutedEventArgs e)
        {

            Select su = new Select();
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



