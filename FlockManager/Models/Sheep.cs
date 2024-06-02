using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlockManager.Models
{
    public class Sheep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String? FarmTag { get; set; }

        public String? ScrapieTag { get; set; }
        [Required]
        public char Sex { get; set; }
        public String? Name { get; set; }

        public DateOnly? BirthDate { get; set; }

        public String? DamId { get; set; }

        public String? SireId { get; set; }
    }
}
