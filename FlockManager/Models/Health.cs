namespace FlockManager.Models
{
    public class Health
    {
        public enum UdderCondition { Healthy, Mast, Unknown }

        public required int Id { get; set; }

        public UdderCondition Udder { get; set; }

        public required Dictionary<String, Boolean> Hoof {  get; set; }
    }
}
