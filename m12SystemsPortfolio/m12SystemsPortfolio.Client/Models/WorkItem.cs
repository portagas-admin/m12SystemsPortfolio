namespace m12SystemsPortfolio.Client.Models
{
    public class WorkItem
    {
        public int Id { get; set; }
        public string Project { get; set; } = "Undefined";
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string Description { get; set; } = "Undefined";
        public bool Active { get; set; } = false;
    }
}
