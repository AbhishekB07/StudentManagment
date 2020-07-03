using DuckTaleSolutionTask.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace DuckTaleSolutionTask.Models.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }



        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().ToTable("StudentInfoTable");
            builder.Entity<Student>().HasKey(p => p.Id);
            builder.Entity<Student>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Student>().Property(p => p.FirstName).IsRequired().HasMaxLength(30);
            builder.Entity<Student>().Property(p => p.LastName).IsRequired().HasMaxLength(30);




            builder.Entity<Subject>().ToTable("SubjectInfoTable");
            builder.Entity<Subject>().HasKey(p => p.Id);
            builder.Entity<Subject>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Subject>().Property(p => p.SubjectName).IsRequired().HasMaxLength(50);
            builder.Entity<Subject>().Property(p => p.Marks).IsRequired();
            builder.Entity<Subject>().Property(p => p.Marks).IsRequired();
            builder.Entity<Subject>()
                .HasOne<Student>(su => su.Student).WithMany(st => st.Subjects).HasForeignKey(su => su.StudentId);

        }
    }
}
