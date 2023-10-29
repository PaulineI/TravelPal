﻿using System.Windows;

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

            txtSignedInUser.Text = UserManager.signedInUser.Username;
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addtravelwindow = new AddTravelWindow();
            addtravelwindow.Show();

        }
    }
}
