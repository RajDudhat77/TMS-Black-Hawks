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
* FILE : done.xaml.cs
* PROJECT : PROG2020 Milestone 4
* PROGRAMMER : Raj Dudhat , Jainish Patel , Shrey Patel , Keerte Dutt
* FIRST VERSION : 12-5-2022
* DESCRIPTION :
* The functions in this file are used to display the message prompt.
*/
namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for done.xaml
    /// </summary>
    public partial class done : Window
    {
        public done()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
