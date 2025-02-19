using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course_Ins
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
