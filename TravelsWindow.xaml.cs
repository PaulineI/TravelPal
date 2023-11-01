using System.Windows;
using System.Windows.Controls;
using TravelPal.Models;


namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {

        public TravelsWindow()
        {
            InitializeComponent();

            if (UserManager.signedInUser!.GetType() == typeof(User))
            {
                txtSignedInUser.Text = UserManager.signedInUser.Username;
                ListViewFill();
            }

            else if (UserManager.signedInUser!.GetType() == typeof(Admin))
            {
                txtSignedInUser.Text = UserManager.signedInUser.Username;

                foreach (Travel t in TravelManager.GetAllTravels())
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = t;
                    item.Content = t.GetInfo();
                    lstAddTravel.Items.Add(item);
                }
            }
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addtravelwindow = new AddTravelWindow();
            addtravelwindow.Show();
            Close();

        }

        public void ListViewFill()
        {
            User user = (User)UserManager.signedInUser;

            foreach (Travel trip in user.Travels)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = trip;
                item.Content = trip.GetInfo();
                lstAddTravel.Items.Add(item);
            }
        }
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstAddTravel.SelectedItem;

            Travel travel = (Travel)selectedItem.Tag;

            // Kolla koden i Virtual Office

            TravelDetailsWindow travelDetailsWindow = new TravelDetailsWindow(travel);
            travelDetailsWindow.Show();
            Close();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (UserManager.signedInUser!.GetType() == typeof(Admin))
            {
                ListViewItem selectedItem = (ListViewItem)lstAddTravel.SelectedItem;

                Travel travel = (Travel)selectedItem.Tag;

                UserManager.AdminRemoveTravel(travel);

                lstAddTravel.Items.Remove(selectedItem);
            }
            else if (UserManager.signedInUser!.GetType() == typeof(User))
            {
                ListViewItem selectedItem = (ListViewItem)lstAddTravel.SelectedItem;

                Travel travel = (Travel)selectedItem.Tag;

                // Ta bort resan från vår "backend"
                ((User)UserManager.signedInUser).Travels.Remove(travel);

                // Ta bort resan från vår frontend
                lstAddTravel.Items.Remove(selectedItem);
            }
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            UserManager.SignOutUser();
            Close();
        }
    }
}
