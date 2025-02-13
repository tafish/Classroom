namespace Classroom.API.Domain.Entities
{
    public class Parent
    {
        public int Id { get; set; } 
        public int Age { get; set; }   
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
