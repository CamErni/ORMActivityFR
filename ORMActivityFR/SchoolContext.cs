using System.Data.Entity;
using ORMActivityFR;
using System.Diagnostics;

namespace ORMActivityFR
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new StudentConfigurations());


            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollment);
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Enrollment);

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}