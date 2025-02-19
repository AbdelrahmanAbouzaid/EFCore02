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
    internal class Course_InsConfiguration : IEntityTypeConfiguration<Course_Ins>
    {
        public void Configure(EntityTypeBuilder<Course_Ins> builder)
        {
            builder.HasKey(ci => new { ci.Inst_Id, ci.Course_Id });

            builder.HasOne(ci => ci.Instructor)
                  .WithMany(i => i.CourseInsts)
                  .HasForeignKey(ci => ci.Inst_Id)
                  .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(ci => ci.Course)
                  .WithMany(c => c.CourseInsts)
                  .HasForeignKey(ci => ci.Course_Id)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
