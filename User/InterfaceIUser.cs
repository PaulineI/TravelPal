namespace TravelPal.User
{
    public interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }


        // Inte lagt in en constructor här som det stod i UML-diagrammet. Constuctorerna finns i de klasser som ärver. 
    }
}
