namespace Classroom.API.Domain.Entities
{
    public class Classroom

    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public double Price { get; set; }

    }
}
