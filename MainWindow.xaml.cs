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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.ShowDialog();
        }
        private void Button_Click_Buyer(object sender, RoutedEventArgs e)
        {
            Planner_login buyer = new Planner_login();
           this.Close();
            buyer.ShowDialog();

            
        }
        private void Button_Click_Planner(object sender, RoutedEventArgs e)
        {
            Planner_login planner = new Planner_login();
            this.Close();
            planner.ShowDialog();
        }
    }
}
