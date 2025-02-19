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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                  .IsRequired() 
                  .HasMaxLength(100); 

            builder.Property(i => i.Salary)
                  .HasColumnType("decimal(18, 2)"); 

            builder.Property(i => i.Address)
                  .HasMaxLength(200); 

            builder.Property(i => i.HourRate)
              .HasColumnType("decimal(18, 2)"); 

           

        }
    }
}
