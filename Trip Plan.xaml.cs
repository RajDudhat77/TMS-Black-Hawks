using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
* FILE : Trip Plan.xaml.cs
* PROJECT : PROG2020 Milestone 4
* PROGRAMMER : Raj Dudhat , Jainish Patel , Shrey Patel , Keerte Dutt
* FIRST VERSION : 12-5-2022
* DESCRIPTION :
* The functions in this file are used to fetch data from the database and to will plan the trip.
*/

namespace TMS_Team_BlackHawks
{
    /// <summary>
    /// Interaction logic for Trip_Plan.xaml
    /// </summary>
    public partial class Trip_Plan : Window
    {
        public double rate = 0.2995;
        public string clientName;
        public string origin;
        public string destination;
        public int tripDistance;

        //variables for distance bettwen cities
        public int windsortolondon = 191;
        public int londontohamilton = 128;
        public int hamiltontotoronto = 68;
        public int torontotobelleville = 60;
        public int bellevilletooshawa = 134;
        public int oshawatokingston = 82;
        public int kingstontoottawa = 196;
        public int[] distancearr = {191,128,68,60,134,82,196};

        //the first cityindex is for origin and 2nd cityindex is for destination
        public int cityindex;
        public int cityindex2;
        
        public Trip_Plan()
        {
            InitializeComponent();
            Planner planner = new Planner();

            //setting values
              clientName = planner.Client.Text;
              origin = planner.tripOrigin.Text;
              destination = planner.tripDestination.Text;


            //here in these series of if else statement we
            //are setting visibility of carriers according to the 
            //origin choice and also sets the first city index
             
            if (origin == "Windsor")
            {
                Scho.Visibility = Visibility.Hidden;
                We_haul.Visibility = Visibility.Hidden;
                cityindex = 0;

            }
            else if (origin == "London")
            {
                We_haul.Visibility = Visibility.Hidden;
                pEX.Visibility = Visibility.Hidden;
                cityindex = 1;
            }
            else if (origin == "Hamilton")
            {
                Scho.Visibility = Visibility.Hidden;
                We_haul.Visibility = Visibility.Hidden;
                cityindex = 2;
            }
            else if (origin == "Toronto")
            {
                pEX.Visibility = Visibility.Hidden;
                Tillman.Visibility = Visibility.Hidden;
                cityindex = 3;
            }
            else if (origin == "Oshawa")
            {
                Scho.Visibility = Visibility.Hidden;
                We_haul.Visibility = Visibility.Hidden;
                Tillman.Visibility = Visibility.Hidden;
                cityindex = 4;
            }
            else if (origin == "Belleville")
            {
                Scho.Visibility = Visibility.Hidden;
                We_haul.Visibility = Visibility.Hidden;
                Tillman.Visibility = Visibility.Hidden;
                cityindex = 5;
            }
            else if (origin == "Kingston")
            {
                pEX.Visibility = Visibility.Hidden;
                We_haul.Visibility = Visibility.Hidden;
                Tillman.Visibility = Visibility.Hidden;
                cityindex = 6;
            }
            else if (origin == "Ottawa")
            {
                Scho.Visibility = Visibility.Hidden;
                Tillman.Visibility = Visibility.Hidden;
                cityindex = 7;
            }

            //we are setting the city index two for destination
            if (destination == "Windsor")
            {
                 
                cityindex2 = 0;

            }
            else if (destination == "London")
            {
                
                cityindex2 = 1;
            }
            else if (destination == "Hamilton")
            {
                
                cityindex2 = 2;
            }
            else if (destination == "Toronto")
            {
                cityindex2 = 3;
            }
            else if (destination == "Oshawa")
            {
              
                cityindex2 = 4;
            }
            else if (destination == "Belleville")
            {
               
                cityindex2 = 5;
            }
            else if (destination == "Kingston")
            {
                
                cityindex2 = 6;
            }
            else if (destination == "Ottawa")
            {
 
                cityindex2 = 7;
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        //this method is used for going back to order status page
        private void status_back(object sender, RoutedEventArgs e)
        {
            Planner trip = new Planner();
            this.Close();
            trip.Show();

        }


        //this method will be called when button plan trip is pressed
        private void Make_trip(object sender, RoutedEventArgs e)
        {
            Planner plan = new Planner();
            if(plan.LTL.IsChecked == true)
            {
                if(pEX.IsChecked==true)
                {
                    rate = 0.3621;
                }
                else if(Scho.IsChecked == true)
                {
                    rate = 0.3434;
                }
                else if(Tillman.IsChecked==true)
                {
                    rate = 0.3012;
                }
                else if(We_haul.IsChecked==true)
                {
                    //ERROR
                }
            }
            else if(plan.FTL.IsChecked == true)
            {
                if (pEX.IsChecked == true)
                {
                    rate = 5.21;
                }
                else if (Scho.IsChecked == true)
                {
                    rate = 5.05;
                }
                else if (Tillman.IsChecked == true)
                {
                    rate = 5.11;
                }
                else if (We_haul.IsChecked == true)
                {
                    rate = 5.2;
                }
            }
            bool loop = true;
            int loopintex = 0;

            //trip distance


            //this while loop will run untill loop index is same as 
            //destination city index (city index 2)
            //case one we are going east to west
            if (cityindex > cityindex2)
            {
                loopintex = cityindex;
                while(loop)
                {
                    tripDistance = tripDistance + distancearr[cityindex];
                    loopintex = loopintex - 1;
                    if(loopintex == cityindex2)
                    {
                        break;
                    }

                }
            }

            //case two we are going west to east
            else if (cityindex < cityindex2)
            {
                loopintex = cityindex2; //setting loop index

                //this while loop will run untill loop index is same as 
                //origin city index (city index )
                while (loop)
                {
                    tripDistance = tripDistance + distancearr[cityindex2];
                    loopintex = loopintex - 1;
                    if (loopintex == cityindex)
                    {
                        break;
                    }

                }
            }
            else
            {
                ///error for same origin and destination
            }

            double tripPrice = tripDistance * rate; //counting trip price
            double profit;
            double profitmargin;


            //counting profit based on which travel method was choosed
            if(plan.LTL.IsChecked == true)
            {
                profitmargin = 0.05;
            }
            else if(plan.FTL.IsChecked == true)
            {
                profitmargin = 0.08;
            }
            else
            {
                profitmargin = 0;
            }

            profit = tripPrice * profitmargin;  

            if(profit != 0) //if profit is zero trip won't be planned
            {

                done done = new done();
                done.Show();
            }
        }
    }
}
