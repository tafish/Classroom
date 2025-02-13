namespace Classroom.API.Domain.Entities
{
    public class Classroom

    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public double Price { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }       
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public List<Discussion> Discussions { get; set; } = new List<Discussion>();
        public List<UserClassroom> UserClassrooms { get; set; } = new List<UserClassroom>();


    }
}
