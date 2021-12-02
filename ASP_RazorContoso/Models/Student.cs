using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_RazorContoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, ErrorMessage = "Maximum 20 characters exceeded")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20, ErrorMessage = "Maximum 20 characters exceeded")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Enrol Date"), DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        // Relationships or navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}