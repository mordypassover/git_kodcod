using Microsoft.EntityFrameworkCore;
using MorningEx.Models;

namespace MorningEx.Data
{
    
    

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
    }
    

}
