namespace TravelPal
{
    public class Vacation : Travel


    {
        public bool AllInclusive { get; set; }

        public Vacation(bool allInclusive, string destination, Country countries, int travellers) : base(destination, countries, travellers)
        {
            AllInclusive = allInclusive;
            Destination = destination;
            Country = countries;
            Travellers = travellers;

        }


        //  TODO: Fixa en extended  GETINFO metod för details.

        public virtual string GetDetails()
        {
            string trip = $"{AllInclusive} {Destination} {Country} {Travellers}";
            return trip;
        }

    }
}
