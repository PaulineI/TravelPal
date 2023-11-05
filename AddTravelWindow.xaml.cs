using System;
using System.Windows;
using TravelPal.Models;


namespace TravelPal;

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
        try
        {
            // Läs alla inputs för att bygga ihop en travel
            string city = txtCity.Text;
            Country country = (Country)cbCountry.SelectedIndex;
            int travellers = int.Parse(txtTravellers.Text);
            Trip typeOfTrip = (Trip)cbTrip.SelectedIndex;
            string meetingDetails = txtMeetings.Text;


            if (city != "" && cbCountry.SelectedIndex > -1 && travellers != 0 && typeOfTrip == Trip.Worktrip)
            {

                User user = (User)UserManager.signedInUser;
                WorkTrip newWorktrip = new(meetingDetails, city, country, travellers);

                user.Travels.Add(newWorktrip);
            }
            else if (city != "" && cbCountry.SelectedIndex > -1 && travellers != 0 && typeOfTrip == Trip.Vacation)
            {
                bool allInclusive = (bool)cbAllInclusive.IsChecked;
                User user = (User)UserManager.signedInUser;
                Vacation newVacation = new(allInclusive, city, country, travellers);

                user.Travels.Add(newVacation);
            }

            else
            {
                MessageBox.Show("Please fill in all the information!");
            }

            TravelsWindow travelsWindow = new();
            travelsWindow.Show();
            Close();
        }
        catch (FormatException)
        {
            MessageBox.Show("Oops! You have to enter a valid number or a valid city!");
            txtCity.Text = "";
            txtTravellers.Text = "";

        }
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

    private void btnReturn_Click(object sender, RoutedEventArgs e)
    {
        TravelsWindow travelswindow = new();
        travelswindow.Show();
        Close();
    }
}
