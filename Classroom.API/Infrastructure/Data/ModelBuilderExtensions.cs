using Microsoft.EntityFrameworkCore;

namespace Classroom.API.Infrastructure.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity <Domain.Entities.Classroom>().HasData(
           new Domain.Entities.Classroom
           {
               Id = 1,
               Title = " #C",
               Description = "Object-oriented programming - OOP",
               IsActive = true,
               Price = 99.99,
               CourseId = 1,
               UserId = 1,
               CreatedAt = DateTime.Now,
               UpdatedAt = DateTime.Now
           },
           new Domain.Entities.Classroom
           {
               Id = 2,
               Title = "SQL",
               Description = "SQL is a standard programming language used to manage and manipulate relational databases.",
               IsActive = true,
               Price = 120.50,
               CourseId = 2,
               UserId = 2,
               CreatedAt = DateTime.Now,
               UpdatedAt = DateTime.Now
           },
           new Domain.Entities.Classroom
           {
               Id = 3,
               Title = "ASP.NET Core",
               Description = "ASP.NET Core is an open-source framework by Microsoft for building web applications",
               IsActive = true,
               Price = 150.00,
               CourseId = 3,
               UserId = 3,
               CreatedAt = DateTime.Now,
               UpdatedAt = DateTime.Now
           }
       );
        }

    }
    }
}
