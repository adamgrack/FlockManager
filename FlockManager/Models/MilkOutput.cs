using System.ComponentModel.DataAnnotations;

namespace FlockManager.Models
{
    public class MilkOutput
    {
        [Key]
        public required int Id { get; set; }

        public DateOnly Date { get; set; }

        public decimal MilkGal { get; set; }
    }
}
