using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Demo.Configurations;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            //modelBuilder.Entity<Employee>().Property(e => e.Id).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Employee>().Property(e => e.Name)
            //                        .HasColumnName("EmployeeName")
            //                        .HasColumnType("varchar")
            //                        .HasMaxLength(50);


            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Employee>().HasOne(d => d.Department)
            //                                .WithOne(d => d.Manager)
            //                                .HasForeignKey<Department>(d => d.EmpId);

            //modelBuilder.Entity<Department>().HasOne(d => d.Manager)
            //                                 .WithOne(e => e.Department)
            //                                 .HasForeignKey<Department>(d => d.EmpId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DemoDb;Trusted_Connection=True;TrustSErverCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
