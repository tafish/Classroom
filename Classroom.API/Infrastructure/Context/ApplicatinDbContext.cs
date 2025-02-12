using Microsoft.EntityFrameworkCore;

namespace Classroom.API.Infrastructure.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
                
        }
        public DbSet<Domain.Entities.Classroom> classrooms{ get; set; }
    }
}
