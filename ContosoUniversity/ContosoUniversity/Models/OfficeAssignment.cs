using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        //There's a one-to-zero-or-one relationship 
        //between the Instructor and the OfficeAssignment entities.


        //You can also use the Key attribute if the entity does 
        //have its own primary key but you want to name the property something
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}