﻿using System;
using System.Collections.Generic;
using ORMActivityFR;
using System.Diagnostics;

namespace ORMActivityFR
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }

        //fully defined relationship
        public int? GradeId { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual StudentAddress Address { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}