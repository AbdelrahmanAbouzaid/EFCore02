﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //OneToMany
        public List<Course> Courses { get; set; }
    }
}
