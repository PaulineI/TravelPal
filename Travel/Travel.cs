namespace TravelPal
{
    public class Travel
    {
        public string Destination { get; set; }
        public string Countries { get; set; }

        public int Travellers { get; set; }


        public Travel(string destination, string countries, int travellers)
        {
            Destination = destination;
            Countries = countries;
            Travellers = travellers;

        }

        //public virtual GetInfo()
        //{
        //    return string 
        //}


    }
}
