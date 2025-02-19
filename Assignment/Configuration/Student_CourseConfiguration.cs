using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configuration
{
    internal class Student_CourseConfiguration : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.HasKey(sc => new { sc.Stud_Id, sc.Course_Id });

            builder.HasOne(sc => sc.Student)
                  .WithMany(s => s.StudentCourse)
                  .HasForeignKey(sc => sc.Stud_Id)
                  .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(sc => sc.Course)
                  .WithMany(c => c.StudCourses)
                  .HasForeignKey(sc => sc.Course_Id)
                  .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
