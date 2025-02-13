﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Classroom.API.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategorieId { get; set; }
        public Categorie? Categorie { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }    
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
        public List<Video> Videos { get; set; } = new List<Video>();
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
    }
}
