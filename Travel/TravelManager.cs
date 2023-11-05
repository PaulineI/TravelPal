using System.Collections.Generic;
using TravelPal.Models;

namespace TravelPal
{
    public static class TravelManager
    {
        public static List<Travel> Travels = new();
        public static List<Travel> GetAllTravels()
        {
            List<Travel> allTravels = new();

            foreach (IUser user in UserManager.ListOfUsers)
            // Loopa genom alla users i Usermanager
            {
                if (user is User)
                {
                    User u = (User)user;

                    allTravels.AddRange(u.Travels);
                }
            }
            // Returnera en sammanslagen lista med alla users resor

            return allTravels;
        }

    }


}
