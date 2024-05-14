namespace FlockManager.Models
{
    public class Sheep
    {
        public required int Id { get; set; }

        public String? Name { get; set; }

        public DateOnly BirthDate { get; set; }
    }
}
