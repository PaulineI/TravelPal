using System;
using System.Windows;
using System.Windows.Controls;
using TravelPal.Models;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        public AddTravelWindow()
        {
            InitializeComponent();

            cbCountry.ItemsSource = Enum.GetValues(typeof(Country));
            cbTrip.ItemsSource = Enum.GetValues(typeof(Trip));

            txtMeetings.Visibility = Visibility.Hidden;
            lbMeeting.Visibility = Visibility.Hidden;
            cbAllInclusive.Visibility = Visibility.Hidden;

        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {

            // Läs alla inputs för att bygga ihop en travel
            string city = txtCity.Text;
            Country country = (Country)cbCountry.SelectedIndex;
            int travellers = int.Parse(txtTravellers.Text);
            Trip typeOfTrip = (Trip)cbTrip.SelectedIndex;

            // Kolla på virtual office

            // Condition ifall rutorna är tomma

            if (city != "" && country != 0 && travellers != 0 && typeOfTrip == Trip.Vacation)
            {
                WorkTrip newWorktrip = new(city, country, travellers);

                User user = (User)UserManager.signedInUser;

                user.Travels.Add(newWorktrip);

                foreach (WorkTrip workTrip in user.Travels)
                {
                    ListViewItem item = new();
                    item.Tag = workTrip;
                    item.Content
                }

            }



            // Skapa en travel
            //if ((Trip)cbTrip.SelectedItem == Trip.Vacation)
            //{
            //    WorkTrip workTrip = new(city, country, travellers);

            //    // Lägg till traveln till vår user
            //    User user = (User)UserManager.signedInUser;

            //    user.Travels.Add(workTrip);

            //}
            //else if ((Trip)cbTrip.SelectedItem == Trip.Vacation)
            //{
            //    Vacation vacation = new(city, country, travellers);

            //    // Lägg till traveln till vår user
            //    User user = (User)UserManager.signedInUser;

            //    user.Travels.Add(vacation);
            //}


            Close();

        }

        private void cbTrip_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if ((Trip)cbTrip.SelectedItem == Trip.Vacation)
            {
                cbAllInclusive.Visibility = Visibility.Visible;
                txtMeetings.Visibility = Visibility.Hidden;
                lbMeeting.Visibility = Visibility.Hidden;
            }
            else if ((Trip)cbTrip.SelectedItem == Trip.Worktrip)
            {
                txtMeetings.Visibility = Visibility.Visible;
                lbMeeting.Visibility = Visibility.Visible;
                cbAllInclusive.Visibility = Visibility.Hidden;
            }

        }
    }
}
