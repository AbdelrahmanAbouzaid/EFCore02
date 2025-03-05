using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        //Navigationl Property


        //OneToMany With Department
        [ForeignKey(nameof(Works))]
        public int? DeptId { get; set; }
        public Department Works { get; set; }


        //OneToOne With Department
        [InverseProperty(nameof(Department.Manager))]
        public Department Department { get; set; }


        //OneToMany With Topic
        public List<CourseInst> CourseInsts { get; set; }


    }
}
