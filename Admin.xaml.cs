/*
* FILE : Admin.xaml.cs
* PROJECT : PROG2020 Milestone 4
* PROGRAMMER : Raj Dudhat , Jainish Patel , Shrey Patel , Keerte Dutt
* FIRST VERSION : 12-5-2022
* DESCRIPTION :
* The functions in this file are used to .
*/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySqlConnector;

namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        string Logpath = @"C:\\Users\\janis\\Dropbox\\PC\\Documents\\C_C++\\TMS_Team_BlackHawks\\TMS_Team_BlackHawks\\bin\\Debug\\Logs";
        string DBIpAddress;
        int DBport;
        public Admin()
        {
            InitializeComponent();
            View_login();
        }

        private void Configuration_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Alter_Click(object sender, RoutedEventArgs e)
        {

        }
        /*
        FUNCTION : Open_rate_fee
        DESCRIPTION : This function is used to set visibility
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
       */
        private void DirectoriesSelection(object sender, RoutedEventArgs e)
        {
            Cv_ConfigDatabase.Visibility = Visibility.Hidden;
            Cv_CareerData.Visibility = Visibility.Hidden;
            Cv_RateFee.Visibility = Visibility.Hidden;
            Cv_RouteTbl.Visibility = Visibility.Hidden;
            Backup_CV.Visibility = Visibility.Hidden;
            Cv_Directories.Visibility = Visibility.Visible;

        }
        /*
        FUNCTION : Open_rate_fee
        DESCRIPTION : This function is used to set visibility of tabs
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
       */
        private void CommDataBase(object sender, RoutedEventArgs e)
        {
            Cv_Directories.Visibility = Visibility.Hidden;
            Cv_RouteTbl.Visibility = Visibility.Hidden;
            Cv_RateFee.Visibility = Visibility.Hidden;
            Cv_CareerData.Visibility = Visibility.Hidden;
            Backup_CV.Visibility = Visibility.Hidden;
            Cv_ConfigDatabase.Visibility = Visibility.Visible;
        }
        /*
         FUNCTION : Open_rate_fee
         DESCRIPTION : This function is used to connect to database and paste data into table.
         PARAMETERS : object sender, RoutedEventArgs e
         RETURNS : void
        */
        private void Open_rate_fee(object sender, RoutedEventArgs e)
        {

            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand("SELECT * FROM tms.fare;", connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();
            Rf_DG.DataContext = dt;

            Cv_Directories.Visibility = Visibility.Hidden;
            Cv_ConfigDatabase.Visibility = Visibility.Hidden;
            Cv_CareerData.Visibility = Visibility.Hidden;
            Cv_RouteTbl.Visibility = Visibility.Hidden;
            Backup_CV.Visibility = Visibility.Hidden;
            Cv_RateFee.Visibility = Visibility.Visible;
        }
        /*
         FUNCTION : Open_CareerData
         DESCRIPTION : This function is used to connect to database and paste data into table.
         PARAMETERS : object sender, RoutedEventArgs e
         RETURNS : void
        */
        private void Open_CareerData(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand("SELECT * FROM tms.carriers;", connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();
            CD_DG.DataContext = dt;

            Cv_Directories.Visibility = Visibility.Hidden;
            Cv_ConfigDatabase.Visibility = Visibility.Hidden;
            Cv_RouteTbl.Visibility = Visibility.Hidden;
            Cv_RateFee.Visibility = Visibility.Hidden;
            Backup_CV.Visibility = Visibility.Hidden;
            Cv_CareerData.Visibility = Visibility.Visible;
        }
        /*
        FUNCTION : Open_RouteData
        DESCRIPTION : This function is used to connect to database and paste data into table.
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
        */
        private void Open_RouteData(object sender, RoutedEventArgs e)
        {


            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand("SELECT * FROM tms.route;", connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();
            R_DG.DataContext = dt;



            Cv_Directories.Visibility = Visibility.Hidden;
            Cv_ConfigDatabase.Visibility = Visibility.Hidden;
            Cv_CareerData.Visibility = Visibility.Hidden;
            Cv_RateFee.Visibility = Visibility.Hidden;
            Backup_CV.Visibility = Visibility.Hidden;
            Cv_RouteTbl.Visibility = Visibility.Visible;
        }
        /*
        FUNCTION : Button_Click
        DESCRIPTION : This function is used to click on the login button.
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Username_TB.Text == "Admin")
            {
                if (Pwd_TB.Text == "123")
                {
                    Login_Error.Content = " ";
                    Hide_login();
                }
                else
                {
                    Login_Error.Content = "Login Error";
                }
            }
            else
            {
                Login_Error.Content = "Login Error";
            }

        }
        /*
        FUNCTION : Hide_login
        DESCRIPTION : This function is used to hide the login button.
        PARAMETERS : void
        RETURNS : void
        */
        private void Hide_login()
        {
            Heading_Admin_Window.Visibility = Visibility.Hidden;
            Rec.Visibility = Visibility.Hidden;
            Username.Visibility = Visibility.Hidden;
            Username_TB.Visibility = Visibility.Hidden;
            Pwd.Visibility = Visibility.Hidden;
            Pwd_TB.Visibility = Visibility.Hidden;
            Btn_Login.Visibility = Visibility.Hidden;
            Login_Error.Visibility = Visibility.Hidden;
            MenuBar.Visibility = Visibility.Visible;
        }
        /*
        FUNCTION : View_login
        DESCRIPTION : This function is used to view the login details.
        PARAMETERS : void
        RETURNS : void
        */
        private void View_login()
        {
            Heading_Admin_Window.Visibility = Visibility.Visible;
            Rec.Visibility = Visibility.Visible;
            Username.Visibility = Visibility.Visible;
            Username_TB.Visibility = Visibility.Visible;
            Pwd.Visibility = Visibility.Visible;
            Pwd_TB.Visibility = Visibility.Visible;
            Btn_Login.Visibility = Visibility.Visible;
            Login_Error.Visibility = Visibility.Visible;
        }
        /*
        FUNCTION : Backup_Event
        DESCRIPTION : This function is used for the vivibility.
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
        */
        private void Backup_Event(object sender, RoutedEventArgs e)
        {
            Cv_ConfigDatabase.Visibility = Visibility.Hidden;
            Cv_CareerData.Visibility = Visibility.Hidden;
            Cv_RateFee.Visibility = Visibility.Hidden;
            Cv_RouteTbl.Visibility = Visibility.Hidden;
            Cv_Directories.Visibility = Visibility.Hidden;
            Backup_CV.Visibility = Visibility.Visible;
        }
        /*
        FUNCTION : cdb_btn1_Click
        DESCRIPTION : This function is used to show the message and ask user to enter the values.
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
        */
        private void cdb_btn1_Click(object sender, RoutedEventArgs e)
        {
            if (cd_tb1.Text != null)
            {
                if (cd_tb2.Text != null)
                {
                    DBIpAddress = cd_tb1.Text;
                    DBport = Convert.ToInt32(cd_tb2.Text);
                    MessageBoxResult message = MessageBox.Show("Success");
                    Cv_ConfigDatabase.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBoxResult message = MessageBox.Show("Please Enter Values");
                }
            }
            else
            {
                MessageBoxResult message = MessageBox.Show("Please Enter Values");
            }


        }

        private void cd_tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /*
        FUNCTION : cdb_btn1_Click
        DESCRIPTION : This function is used to open the file.
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
        */
        private void cd_btn1_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Folders|\n|All files (*.*)|*.*";
            openFileDialog.AddExtension = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.DereferenceLinks = true;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            openFileDialog.ValidateNames = false;
            Logpath = openFileDialog.SafeFileName;
            if (Logpath != null)
            {

                Cv_ConfigDatabase.Visibility = Visibility.Hidden;
            }
        }
        /*
        FUNCTION : RF_Submit_BTN_Click
        DESCRIPTION : This function is used to connect to mysql database.
        PARAMETERS : object sender, RoutedEventArgs e
        RETURNS : void
        */
        private void RF_Submit_BTN_Click(object sender, RoutedEventArgs e)
        {
            string query;
            query = RF_Query_TB.Text;
            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();
            MessageBoxResult message = MessageBox.Show("Processed");
        }
        /*
       FUNCTION : CD_Submit_BTN_Click
       DESCRIPTION : This function is used to show the message processed when submit button is clicked.
       PARAMETERS : object sender, RoutedEventArgs e
       RETURNS : void
       */
        private void CD_Submit_BTN_Click(object sender, RoutedEventArgs e)
        {
            string query;
            query = CD_Query_TB.Text;

            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();
            MessageBoxResult message = MessageBox.Show("Processed");
        }
        /*
       FUNCTION : RT_Submit_BTN_Click
       DESCRIPTION : This function is used to show the message processed when submit button is clicked.
       PARAMETERS : object sender, RoutedEventArgs e
       RETURNS : void
       */
        private void RT_Submit_BTN_Click(object sender, RoutedEventArgs e)
        {
            string query;
            query = RT_Query_TB.Text;
            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();

            MessageBoxResult message = MessageBox.Show("Processed");
        }
        /*
       FUNCTION : Backup_Button
       DESCRIPTION : This function is used to show the message processed when submit button is clicked.
       PARAMETERS : object sender, RoutedEventArgs e
       RETURNS : void
       */
        private void Backup_Button(object sender, RoutedEventArgs e)
        {
            string query;
            query = BKP_Query_TB.Text;
            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "server=localhost;userid=root;password=1234;database=TMS";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand(query, connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connect.Close();
            MessageBoxResult message = MessageBox.Show("Processed");
        }
    }
}
