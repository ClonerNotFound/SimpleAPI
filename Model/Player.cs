namespace SimpleAPI.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int HoursPlayed { get; set; }
    }

}
