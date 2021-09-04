

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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUps : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public SignUps()
        {
            InitializeComponent();
        }
        string uNameError;
        string passError;
        string phNumError;
        string nameError;

        private void Button_Create_Account(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
            {
                nameError = "Name is required!";
                nameErr.Content = nameError;
            }
            else
            {
                nameErr.Content = "";
            }
            if (uName.Text == "")
            {
                uNameError = "User Name is required!";
                uNameErr.Content = uNameError;
            }
            else
            {
                uNameErr.Content = "";
            }
            if (phNum.Text == "")
            {
                phNumError = "Phone Number is required!";
                phNumErr.Content = phNumError;
            }
            else
            {
                phNumErr.Content = "";
            }
            if (pass.Text == "")
            {
                passError = "Password is required!";
                passErr.Content = passError;
            }
            else
            {
                passErr.Content = "";
            }
            if (name.Text != "" && uName.Text != "" && phNum.Text != "" && pass.Text != "")
            {

                if ((bool)cbAcceptTC.IsChecked)
                {
                    SqlConnection con = new SqlConnection();

                    con.ConnectionString = @"Data Source=SATELLITE;Initial Catalog=Renting;Integrated Security=True";


                    string uNamed = uName.Text;
                    string phNumd = phNum.Text;
                    string passd = pass.Text;
                    string named = name.Text;

                    string sql = "INSERT INTO User_Info(UserName, PhoneNumber, Password, Name)"
                                 + "VALUES(" + "'" + uNamed + "'" + ","
                                 + "'" + phNumd + "'" + ","
                                 + "'" + passd + "'" + ","
                                 + "'" + named + "'" + ")";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    Select lg = new Select();
                    lg.Show();
                    this.Hide();
                }
                //MessageBox.Show("Student box connected successfully");
                else
                {
                    MessageBox.Show("You have to accept the terms and conditions");
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


