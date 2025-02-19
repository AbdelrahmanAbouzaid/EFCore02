using Demo.contexts;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AppDbContext context = new AppDbContext();

            //try
            //{
            //    // code
            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using (AppDbContext context = new AppDbContext())
            //{

            //}

            using AppDbContext context = new AppDbContext();

            // CRUD
            // Create - Read[Retreive] - Update - Remove

            #region Create : Insert
            // Create : Insert
            /* insert into Employees
             * values('Abdo',12000, 22,'Cairo')
             */

            //var employee = new Employee()
            //{
            //    Name = "Abdo",
            //    Address = "Cairo",
            //    Age = 22,
            //    Salary = 12000
            //};
            //Console.WriteLine(context.Entry(employee).State); // Detached

            //employee.Name = "Abdelrahman";
            //Console.WriteLine(context.Entry(employee).State); // Detached

            //context.Employees.Add(employee);
            //Console.WriteLine(context.Entry(employee).State); // Added

            //int result = context.SaveChanges();
            //Console.WriteLine(result);

            //Console.WriteLine(context.Entry(employee).State); // Unchanged

            //employee.Name = "Omar";
            //Console.WriteLine(context.Entry(employee).State); // Modified

            //var employee = new Employee()
            //{
            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Age = 22,
            //    Salary = 12000
            //};

            ////context.Employees.Add(employee);

            ////context.Entry(employee).State = EntityState.Added;
            ////context.SaveChanges();

            //employee.Name = "Omar";
            ////context.Employees.Add(employee);
            ////context.Entry(employee).State = EntityState.Modified;

            //context.SaveChanges(); 
            #endregion

            #region Read : Select
            // Read : Select

            /* Select * 
             * From Employees
             * where Id = 30
             */

            //var result = context.Employees.SingleOrDefault(e => e.Id == 30);
            //result = context.Employees.Find(210);
            //Console.WriteLine(result);

            //var result = context.Employees;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Update
            // Update

            /* Update Employees
             * set Name = 'Ali'
             * where Id = 10
             */

            //var result = context.Employees.Find(10);
            //var result = context.Employees.FirstOrDefault(e => e.Id == 10);
            //Console.WriteLine(context.Entry(result).State); // UnChanged
            //result.Name = "Ali";
            //Console.WriteLine(context.Entry(result).State); // Modified

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); // UnChanged

            //var result = context.Employees.FirstOrDefault(e => e.Id == 10);
            //Console.WriteLine(context.Entry(result).State); // UnChanged
            //result.Name = "Ali";
            //Console.WriteLine(context.Entry(result).State); // UnChanged

            //context.Update(result);
            //Console.WriteLine(context.Entry(result).State); // Modified

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); // UnChanged 
            #endregion

            #region Delete
            // Delete

            /* Delete from Employees
             * where Id = 10
             */

            //var result = context.Employees.FirstOrDefault(e => e.Id == 20);
            //Console.WriteLine(context.Entry(result).State); // UnChanged
            ////context.Entry(result).State = EntityState.Deleted;
            //if (result is not null)
            //{
            //    context.Remove(result);
            //    Console.WriteLine(context.Entry(result).State); // Deleted
            //}

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); // Detached 
            #endregion

        }
    }
}
