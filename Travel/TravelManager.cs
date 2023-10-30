using System.Collections.Generic;

namespace TravelPal
{
    public static class TravelManager
    {
        public static List<Travel> GetAllTravels()
        {
            List<Travel> allTravels = new List<Travel>()
            {
                new WorkTrip("London", Country.UnitedKingdom, 2),
                new Vacation("Istanbul", Country.Spain, 4)
            };

            //foreach (IUser user in UserManager.ListOfUsers)
            //// Loopa genom alla users i Usermanager
            //{
            //    if (user is User)
            //    {
            //        User u = (User)user;

            //        allTravels.AddRange(u.Travels);
            //    }
            //}
            //// Returnera en sammanslagen lista med alla users resor

            return allTravels;
        }

        public static void RemoveTravel(Travel travel)
        {

        }

    }


}
