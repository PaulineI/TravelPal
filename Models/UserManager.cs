using System.Collections.Generic;
using System.Windows;


namespace TravelPal.Models
{
    public static class UserManager
    {

        public static List<IUser> ListOfUsers = new()
        {
            new User ("user", "password"),
            //Definierade User högst upp i koden, eftersom datorn blev förvirrad av att Namespace och klass heter samma sak och ville därför inte gå till constructorn. 
            new Admin("admin", "password")
        };

        public static IUser signedInUser { get; set; }


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



    }
}



