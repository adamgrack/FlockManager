using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlockManager.Models
{
    public class Health
    {
        public enum UdderCondition { Healthy, Mast, Unknown }
        public enum HoofCondition { Good, Bad }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }

        public String? Tag { get; set; }

        public DateOnly Date { get; set; }

        public UdderCondition Udder { get; set; }
        
        public HoofCondition FLHoof {  get; set; }

        public HoofCondition FRHoof { get; set; }

        public HoofCondition BLHoof { get; set; }

        public HoofCondition BRHoof { get; set; }

        public String? Notes { get; set; }
    }
}
