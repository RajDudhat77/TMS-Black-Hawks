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
/*
* FILE : Planner login.xaml.cs
* PROJECT : PROG2020 Milestone 4
* PROGRAMMER : Raj Dudhat , Jainish Patel , Shrey Patel , Keerte Dutt
* FIRST VERSION : 12-5-2022
* DESCRIPTION :
* The functions in this file are used to display the home page of the login page.
*/
namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for Planner_login.xaml
    /// </summary>
    public partial class Planner_login : Window
    {
        public Planner_login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Username_TB.Text == "" || Pwd_TB.Text == "")
            {
                errorUNamePass.Visibility = Visibility.Visible;
            }
            else
            {
                Planner planner = new Planner();
                this.Close();
                planner.Show();
            }
          
             

        }
    }
}
