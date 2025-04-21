namespace ApplicationTrackerAPI.Models
{
    public class Application
    {
        public int Id { get; set; }
        public required string CompanyName { get; set; }
        public required string Position { get; set; }
        public required string Status { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}