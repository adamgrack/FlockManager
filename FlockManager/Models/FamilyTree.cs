namespace FlockManager.Models
{
    public class FamilyTree
    {
        public required int Id { get; set; }

        public required int DamId { get; set; }

        public required int SireId { get; set; }
    }
}
