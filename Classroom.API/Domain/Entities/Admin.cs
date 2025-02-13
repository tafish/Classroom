namespace Classroom.API.Domain.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public DateTime RegisterDate { get; set; }
    }
}
