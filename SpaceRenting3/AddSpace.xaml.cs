
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
    /// Interaction logic for AddSpace.xaml
    /// </summary>
    public partial class AddSpace : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public AddSpace()
        {
            InitializeComponent();

            string[] spacetype = new string[3];
            spacetype[0] = "Rooftop";
            spacetype[1] = "Parking";
            spacetype[2] = "Land";

            cmbSpaceType.ItemsSource = spacetype;
        }
        string uNameError;
        string phNumError;
        string costError;
        string locationError;
        string spaceTypeError;


        private void Button_Insert_Space(object sender, RoutedEventArgs e)
        {

            if (txtUsername.Text == "")
            {
                uNameError = "User Name is required!";
                uNameErr.Content = uNameError;
            }
            else
            {
                uNameErr.Content = "";
            }
            if (txtLocation.Text == "")
            {
                locationError = "Location is required!";
                locationErr.Content = locationError;
            }
            else
            {
                locationErr.Content = "";
            }
            if (txtPhoneNumber.Text == "")
            {
                phNumError = "Phone Number is required!";
                phNumErr.Content = phNumError;
            }
            else
            {
                phNumErr.Content = "";
            }
            if (txtCost.Text == "")
            {
                costError = "Cost is required!";
                costErr.Content = costError;
            }
            else
            {
                costErr.Content = "";
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

            if (txtUsername.Text != "" && txtLocation.Text != "" && txtPhoneNumber.Text != "" && txtCost.Text != "" && SPACETYPE != "")
            {
               
                    SqlConnection con = new SqlConnection();

                    con.ConnectionString = "Data Source=SATELLITE;Initial Catalog=Renting;Integrated Security=True";



                    string USERNAME = txtUsername.Text;

                    string LOCATION = txtLocation.Text;

                    string PHONENUMBER = txtPhoneNumber.Text;

                    

                    string COST = txtCost.Text;

                
                //    string SPACETYPE = cmbSpaceType.SelectedItem.ToString();
                string sql = "INSERT INTO Space_Info(Username,Location,PhoneNumber,SpaceType,Cost)"
                                 + "VALUES(" + "'" + USERNAME + "'" + ","
                                 + "'" + LOCATION + "'" + ","
                                 + "'" + PHONENUMBER + "'" + ","
                                 + "'" + SPACETYPE + "'" + ","
                                 + "'" + COST + "'" + ")";


                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
              
                MessageBox.Show("Space inserted successfully");
                    
                
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



