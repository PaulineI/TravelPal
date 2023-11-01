namespace TravelPal
{
    public class WorkTrip : Travel
    {

        public string MeetingDetails { get; set; }

        public WorkTrip(string meetingDetails, string destination, Country countries, int travellers) : base(destination, countries, travellers)
        {
            MeetingDetails = meetingDetails;
        }


        public override string GetDetails()
        {
            string info = base.GetInfo();

            info += $" | Meeting Details: {MeetingDetails} | Quantity: {Travellers}";

            return info;
        }
    }
}

