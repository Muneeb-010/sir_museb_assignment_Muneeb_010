using assignment_muneeb.data;
using Microsoft.EntityFrameworkCore;

namespace assignement_muneeb.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }
        public DbSet<Mark> Marks { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Enrolled>()
                .HasKey(e => new { e.Eid, e.Sid });

            
            modelBuilder.Entity<Enrolled>()
                .HasOne(e => e.Class)
                .WithMany(c => c.Enrolled)
                .HasForeignKey(e => e.Sid);

            
            modelBuilder.Entity<Enrolled>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrolled)
                .HasForeignKey(e => e.Sid);


        }

    }
}
