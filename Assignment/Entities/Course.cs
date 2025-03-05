using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        //Navigational Property

        //OneToMany With Topic
        [ForeignKey(nameof(Topic))]
        public int? TopId { get; set; }
        public Topic Topic { get; set; }

        //OneToMany With Topic
        public List<CourseInst> CourseInsts { get; set; }

        //OneToMany With StudentCourse
        public List<StudentCourse> StudentCourses { get; set; }

    }
}
