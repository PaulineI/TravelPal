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

        public virtual string GetInfo()
        {
            string trip = $"{Destination} {Country} {Travellers}";

            return trip;
        }


    }
}
