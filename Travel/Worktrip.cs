namespace TravelPal
{
    public class WorkTrip : Travel
    {

        public string MeetingDetails { get; set; }

        public WorkTrip(string destination, Country countries, int travellers) : base(destination, countries, travellers)
        {

        }


    }
}
