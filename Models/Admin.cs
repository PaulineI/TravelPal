using System.Diagnostics.CodeAnalysis;

namespace TravelPal.Models
{
    public class Admin : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }


        [SetsRequiredMembers]

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;

        }
    }
}
