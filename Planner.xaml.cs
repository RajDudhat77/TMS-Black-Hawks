using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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

/*
* FILE : Planner.xaml.cs
* PROJECT : PROG2020 Milestone 4
* PROGRAMMER : Raj Dudhat , Jainish Patel , Shrey Patel , Keerte Dutt
* FIRST VERSION : 12-5-2022
* DESCRIPTION :
* The functions in this file are used to display the data from the database and some client information.s
*/

namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for Planner.xaml
    /// </summary>
    public partial class Planner : Window
    {
        public Planner()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            string database = "SERVER=159.89.117.198;DATABASE=cmp;UID=DevOSHT;PASSWORD=Snodgr4ss!;";
            MySqlConnection connect = new MySqlConnection(database);
            MySqlCommand command = new MySqlCommand("SELECT * FROM cmp.Contract;", connect);
            connect.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());   
            connect.Close();
            buyerdata.DataContext = dt; 
             
        }

        private void Configuration_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buyerdata_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_trip(object sender, RoutedEventArgs e)
        {
            Trip_Plan trip = new Trip_Plan();
            this.Close();
            trip.Show();

        }
    }
}
