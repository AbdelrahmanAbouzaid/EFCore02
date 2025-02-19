using Assignment.Configuration;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Contexts
{
    internal class ITIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ITIApp; Trusted_Connection=true; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
           .HasKey(s => s.Id);

            modelBuilder.Entity<Student>()
                .Property(s => s.FName)
                .HasColumnName("FirstName");

            modelBuilder.Entity<Student>()
                .Property(s => s.LName)
                .HasColumnName("LastName");

            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student_Course> StudentCourses { get; set; }
        public DbSet<Course_Ins> CourseInsts { get; set; }
    }
}
