using System.Collections.Generic;
using System.Data.Entity;
using ORMActivityFR;
using System.Diagnostics;

namespace ORMActivityFR
{
    public class SchoolDBInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Grade> grades = new List<Grade>();

            grades.Add(new Grade() { GradeName = "Grade 1", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "B" });
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "C" });
            grades.Add(new Grade() { GradeName = "Grade 2", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade 3", Section = "A" });

            context.Grades.AddRange(grades);

            base.Seed(context);
        }
    }
}