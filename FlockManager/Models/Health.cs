using System.ComponentModel.DataAnnotations;

namespace FlockManager.Models
{
    public class Health
    {
        public enum UdderCondition { Healthy, Mast, Unknown }
        [Key]
        public required int Id { get; set; }

        public UdderCondition Udder { get; set; }
        [Required]
        public required Dictionary<String, Boolean> Hoof {  get; set; }
    }
}
