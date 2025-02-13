using NPOI.POIFS.Properties;

namespace Classroom.API.Domain.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public Parent? parent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
       
    }
}
