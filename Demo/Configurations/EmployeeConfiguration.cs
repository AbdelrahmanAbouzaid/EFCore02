using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
           builder.HasKey(e => e.Id);
           builder.Property(e => e.Id).UseIdentityColumn(10, 10);
           builder.Property(e => e.Name)
                                    .HasColumnName("EmployeeName")
                                    .HasColumnType("varchar")
                                    .HasMaxLength(50);
        }
    }
}
