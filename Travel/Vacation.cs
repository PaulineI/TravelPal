namespace TravelPal
{
    public class Vacation : Travel


    {
        public bool AllInclusive { get; set; }

        public Vacation(string destination, Country countries, int travellers) : base(destination, countries, travellers)
        {

        }

        public void vacation(bool allInclusive)
        {
            AllInclusive = allInclusive;

            //string input = cbAll

        }

    }
}
