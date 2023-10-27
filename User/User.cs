using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TravelPal.User
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Travel> travels { get; set; }

        [SetsRequiredMembers]


        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
