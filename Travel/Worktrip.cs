namespace TravelPal
{
    public class WorkTrip : Travel
    {

        public string meetingDetails { get; set; }

        public WorkTrip(string destination, string countries, int travellers) : base(destination, countries, travellers)
        {

        }


    }
}
