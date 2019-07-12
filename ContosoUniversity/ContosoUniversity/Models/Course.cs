using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //attribute lets you enter the primary key for the course rather than having the database generate it.
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
