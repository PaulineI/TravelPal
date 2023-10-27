namespace TravelPal
{
    public class Travel
    {
        public string _destination { get; set; }
        public string _countries { get; set; }

        public int _travellers { get; set; }


        public Travel(string destination, string countries, int travellers)
        {
            _destination = destination;
            _countries = countries;
            _travellers = travellers;

        }

        //public virtual GetInfo()
        //{
        //    return string 
        //}


    }
}
