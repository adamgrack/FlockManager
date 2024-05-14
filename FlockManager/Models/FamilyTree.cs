using System.ComponentModel.DataAnnotations;

namespace FlockManager.Models
{
    public class FamilyTree
    {
        [Key]
        public required int Id { get; set; }
        [Required]
        public required int DamId { get; set; }
        [Required]
        public required int SireId { get; set; }
    }
}
