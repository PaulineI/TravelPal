using System;
using System.Windows;
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
            string meetingDetails = txtMeetings.Text;

            // Condition ifall rutorna är tomma

            if (city != "" && country != 0 && travellers != 0 && typeOfTrip == Trip.Worktrip)
            {

                User user = (User)UserManager.signedInUser;
                WorkTrip newWorktrip = new(meetingDetails, city, country, travellers);

                user.Travels.Add(newWorktrip);

            }

            else if (city != "" && country != 0 && travellers != 0 && typeOfTrip == Trip.Vacation)
            {
                bool allInclusive = (bool)cbAllInclusive.IsChecked;
                User user = (User)UserManager.signedInUser;
                Vacation newVacation = new(allInclusive, city, country, travellers);

                user.Travels.Add(newVacation);

            }

            TravelsWindow travelsWindow = new();
            travelsWindow.Show();
            Close();


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
