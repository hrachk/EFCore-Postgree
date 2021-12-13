using Microsoft.EntityFrameworkCore;
 

namespace EFCore.Entities
{
    public class Context:DbContext
    {
        public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=db;username=postgres;password=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(p => p.DepartmentName).HasColumnName("DepName");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Department> Departments { get; set; } 
    }
}
