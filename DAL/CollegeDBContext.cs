using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DAL
{
    public class CollegeDBContext : DbContext
    {
        public CollegeDBContext(DbContextOptions options) : base(options){
        
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; } 
    }
}
