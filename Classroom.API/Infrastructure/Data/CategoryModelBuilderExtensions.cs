using Classroom.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Classroom.API.Infrastructure.Data
{
    public static class CategoryModelBuilderExtensions
    {
        public static void CategorieSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().HasData(
                new Domain.Entities.Categorie
                {
                    Id = 1,
                    Name = "Programming",
                    ParentId = 0,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Categorie
                {
                    Id = 2,
                    Name = "Web Development",
                    ParentId = 1, 
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Categorie
                {
                    Id = 3,
                    Name = "Databases",
                    ParentId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Categorie
                {
                    Id = 4,
                    Name = "ASP.NET",
                    ParentId = 2, 
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Domain.Entities.Categorie
                {
                    Id = 5,
                    Name = "SQL",
                    ParentId = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
    }
}
