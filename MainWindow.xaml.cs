﻿using System.Windows;
using TravelPal.Models;

namespace TravelPal
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
            RegisterWindow Register = new();
            Register.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("User not found!");
                return;
            }
            else if (txtUsername.Text != null && txtPassword.Password != null)
            {
                UserManager.SignInUser(username, password);

                TravelsWindow travelsWindow = new TravelsWindow();
                travelsWindow.Show();
                Close();
            }

        }
    }
}
