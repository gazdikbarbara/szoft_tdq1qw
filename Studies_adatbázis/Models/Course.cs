﻿using System;
using System.Collections.Generic;

namespace Studies_adatbázis.Models
{
    public partial class Course
    {
        public Course()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int CourseSk { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
