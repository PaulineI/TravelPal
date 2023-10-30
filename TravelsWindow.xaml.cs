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
            ListViewFill();

            txtSignedInUser.Text = UserManager.signedInUser.Username;
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addtravelwindow = new AddTravelWindow();
            addtravelwindow.Show();

        }

        public void ListViewFill()
        {
            foreach (Travel travel in Travels)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = travel;
                item.Content = travel.GetInfo();

                lstAddTravel.Items.Add(item);

            }

        }

    }
}
