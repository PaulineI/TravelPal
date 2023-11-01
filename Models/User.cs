using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TravelPal.Models
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Travel> Travels { get; set; } = new()
        {
        };



        [SetsRequiredMembers]




        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}
