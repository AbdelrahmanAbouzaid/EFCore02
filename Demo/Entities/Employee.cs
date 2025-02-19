using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //[InverseProperty(nameof(Department.Manager))]
        public Department Department { get; set; }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}, Salary: {Salary}, Age: {Age} ";
        }
    }
}
