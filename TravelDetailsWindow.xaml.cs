using System.Windows;
using System.Windows.Controls;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {
        public TravelDetailsWindow(Travel travel)
        {
            InitializeComponent();


            ListViewItem item = new ListViewItem();
            item.Tag = travel;
            item.Content = travel.GetDetails();
            lstDetails.Items.Add(item);


            //public void ListViewDetailsFill()
            //{
            //    User user = (User)UserManager.signedInUser;


            //    foreach (Vacation trip in user.Travels)
            //    {
            //        ListViewItem item = new ListViewItem();
            //        item.Tag = trip;
            //        item.Content = trip.GetDetailsVacation();
            //        lstDetails.Items.Add(item);
            //    }

            //    foreach (WorkTrip worktrip in user.Travels)
            //    {
            //        ListViewItem item = new ListViewItem();
            //        item.Tag = worktrip;
            //        item.Content = worktrip.GetDetailsWorktrip();
            //    }

            //}

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelswindow = new TravelsWindow();
            travelswindow.Show();

            Close();
        }
    }
}

