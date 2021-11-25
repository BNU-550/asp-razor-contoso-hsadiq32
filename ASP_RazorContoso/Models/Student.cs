using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ASP_RazorContoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Enrol Date")]
        public DateTime EnrollmentDate { get; set; }
        // Relationships or navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}