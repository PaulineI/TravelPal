namespace TravelPal
{
    public class Vacation : Travel


    {
        public bool AllInclusive { get; set; }

        public Vacation(bool allInclusive, string destination, Country countries, int travellers) : base(destination, countries, travellers)
        {
            AllInclusive = allInclusive;
        }

        public void vacation(bool allInclusive)
        {
            AllInclusive = allInclusive;

            //string input = cbAll

        }

    }
}
