using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }


        public int TopicID { get; set; }
        public Topic Topic { get; set; }
        public List<Student_Course> StudCourses { get; set; }
        public List<Course_Ins> CourseInsts { get; set; }
    }
}
