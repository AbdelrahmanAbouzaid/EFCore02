using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    internal class CourseInst
    {
        
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        public string Evaluate { get; set; }
    }
}
