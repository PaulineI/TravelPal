namespace TravelPal
{
    public class Travel
    {
        public string Destination { get; set; }
        public Country Country { get; set; }

        public int Travellers { get; set; }

        public Travel(string destination, Country countries, int travellers)
        {
            Destination = destination;
            Country = countries;
            Travellers = travellers;

        }

        public string GetInfo()
        {
            string trip = $"City: {Destination} | Country: {Country} ";

            return trip;
        }

        public virtual string GetDetails()
        {
            return GetInfo();
        }
    }
}
