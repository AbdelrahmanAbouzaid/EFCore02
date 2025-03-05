using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        //Navigationl Property

        //OneToOne With Instructor
        [ForeignKey(nameof(Manager))]
        public int? InstId { get; set; }
        [InverseProperty(nameof(Instructor.Department))]
        public Instructor Manager { get; set; }

        //OneToMany with Instructors
        public List<Instructor> Instructors { get; set; }


        //OneToMany with Student
        public List<Student> Students { get; set; }

    }
}
