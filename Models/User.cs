using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TravelPal.Models
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static List<Travel> Travels { get; set; } = new()
        {
            new WorkTrip("London", Country.UnitedKingdom, 2),
            new Vacation("Istanbul", Country.Spain, 4)
        };

        [SetsRequiredMembers]


        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
