using System.ComponentModel.DataAnnotations;

namespace FlockManager.Models
{
    public class Health
    {
        public enum UdderCondition { Healthy, Mast, Unknown }
        public enum HoofCondition { Good, Bad }
        [Key]
        public required int Id { get; set; }

        public UdderCondition Udder { get; set; }
        
        public HoofCondition FLHoof {  get; set; }

        public HoofCondition FRHoof { get; set; }

        public HoofCondition BLHoof { get; set; }

        public HoofCondition BRHoof { get; set; }
    }
}
