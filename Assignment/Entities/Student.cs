using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        //Navigational Property

        //OneToMany with Department
        [ForeignKey(nameof(Department))]
        public int? DeptId { get; set; }
        public Department Department { get; set; }

        //OneToMany With StudentCourse
        public List<StudentCourse> StudentCourses { get; set; }

    }
}
