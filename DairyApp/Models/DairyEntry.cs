namespace DairyApp.Models
{
    public class DairyEntry
    {
        
        public int DairyEntryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
