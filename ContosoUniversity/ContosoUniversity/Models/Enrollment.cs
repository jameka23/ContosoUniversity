using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } // note that the EnrollmentID could also just be ID
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } // grade is of enum type and nullable value
        
        // navigation properties
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
