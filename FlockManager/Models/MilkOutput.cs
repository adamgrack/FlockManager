using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlockManager.Models
{
    public class MilkOutput
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }

        public String? Tag { get; set; }

        public DateOnly Date { get; set; }

        public decimal MilkPounds { get; set; }
    }
}
