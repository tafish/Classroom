using NPOI.POIFS.Properties;

namespace Classroom.API.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public Parent? Parent { get; set; }
    }
}

