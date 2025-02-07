
using System;
using System.Collections;
using System.Collections.Generic;


namespace ORMActivityFR
{
    public class Enrollment
    {
        public Enrollment()
        {
        }
        public int EnrollmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}

