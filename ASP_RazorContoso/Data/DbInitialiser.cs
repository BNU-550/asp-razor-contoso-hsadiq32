using ASP_RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Ruairi",LastName="Hawes",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Millie",LastName="Storey",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Carys",LastName="Brock",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Priyanka",LastName="Parkes",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Arnold",LastName="Carys",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Renesmae",LastName="Chen",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Meghan",LastName="Clegg",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Korban",LastName="Melendez",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=558,Title="Database Design-21S1",Credits=3},
                new Course{CourseID=566,Title="Mobile Systems-21S2",Credits=3},
                new Course{CourseID=556,Title="Network Systems-21S1",Credits=3},
                new Course{CourseID=567,Title="Object Oriented Systems Development-21S1",Credits=4},
                new Course{CourseID=551,Title="Open Source Systems-21S2",Credits=4},
                new Course{CourseID=557,Title="Software Engineering-21S2",Credits=3},
                new Course{CourseID=550,Title="Web Applications-21S1",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=558,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=566,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=556,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=567,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=551,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=557,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=558},
                new Enrollment{StudentID=4,CourseID=558},
                new Enrollment{StudentID=4,CourseID=566,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=556,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=567},
                new Enrollment{StudentID=7,CourseID=551,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
