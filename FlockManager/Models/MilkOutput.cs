namespace FlockManager.Models
{
    public class MilkOutput
    {
        public required int Id { get; set; }

        public DateOnly Date { get; set; }

        public decimal MilkGal { get; set; }
    }
}
