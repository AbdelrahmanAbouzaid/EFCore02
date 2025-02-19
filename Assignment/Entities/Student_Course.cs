using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Student_Course
    {

        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
