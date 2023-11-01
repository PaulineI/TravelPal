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

        public override string GetDetails()
        {
            if (AllInclusive)
            {
                string info = base.GetInfo();
                info += $" | All Inclusive - Yes! | Quantity: {Travellers}";

                return info;
            }
            else
            {
                string info = base.GetInfo();
                info += $" | All Inclusive - No! | Quantity {Travellers}";

                return info;
            }
        }

    }
}
