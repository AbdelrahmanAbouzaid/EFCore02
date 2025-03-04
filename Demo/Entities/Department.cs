using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ////public int ManagerId { get; set; } // FK
        [ForeignKey(nameof(Manager))] // If We Have mor than one relation[Navigational property]
        public int EmpId { get; set; } // FK
        public Employee Manager { get; set; } // Navigational property

        public List<Employee> Employees { get; set; }

    }
}
