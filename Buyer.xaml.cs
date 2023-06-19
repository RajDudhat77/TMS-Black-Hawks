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

namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for Buyer.xaml
    /// </summary>
    public partial class Buyer : Window
    {
        public Buyer()
        {
            InitializeComponent();
            View_login();
        }
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

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if (Username_TB.Text == "Buyer")
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
    }
}
