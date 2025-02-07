using System.Collections.Generic;
using ORMActivityFR;

namespace ORMActivityFR
{
    public class Course
    {
        public Course()
        {
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}