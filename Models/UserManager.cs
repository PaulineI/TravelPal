using System.Collections.Generic;
using System.Windows;


namespace TravelPal.Models
{
    public static class UserManager
    {

        public static List<IUser> ListOfUsers = new()
        {
            new User ("user", "password") { Travels = new List<Travel>()
            {
                new WorkTrip("Conference city", "Paris", Country.France, 2),
                new Vacation(true, "Split", Country.Croatia, 5)
            }
            },

            new Admin("admin", "password")
        };

        public static IUser signedInUser { get; set; }

        public static void AdminRemoveTravel(Travel travelToRemove)
        {
            //Loopa över alla users
            foreach (var user in ListOfUsers)
            {
                if (user is User)
                {
                    //Kolla i varje users lista med resor

                    foreach (var userTravel in ((User)user).Travels)
                    {
                        //Hittas resan som ska tas bort... Ta bort den!

                        if (userTravel == travelToRemove)
                        {
                            ((User)user).Travels.Remove(travelToRemove);

                            return;
                        }
                    }
                }
            }
        }

        public static IUser? AddUser(string username, string password)
        {
            if (ValidateUsername(username) == true)
            {
                User user = new User(username, password);

                ListOfUsers.Add(user);

                MessageBox.Show("You are now a registered user!");

                return user;
            }

            return null;
        }

        private static bool ValidateUsername(string username)
        {

            foreach (var user in ListOfUsers)
            {
                if (user.Username == username)
                {
                    MessageBox.Show("Username is taken!"); return false;

                }
            }
            return true;
        }

        public static bool SignInUser(string username, string password)
        {
            foreach (var user in ListOfUsers)
            {
                if (user.Username == username && user.Password == password)
                {
                    signedInUser = user;

                    return true;
                }

            }
            MessageBox.Show("User not found!");
            return false;
        }

        public static void SignOutUser()
        {
            signedInUser = null;
        }

    }
}



