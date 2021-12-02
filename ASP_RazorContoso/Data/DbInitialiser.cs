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
            AddStudents(context);
            AddCourses(context);
            AddEnrolments(context);
        }

        private static void AddStudents(ApplicationDbContext context)
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
        }

        private static void AddCourses(ApplicationDbContext context)
        {
            // Looks for modules
            if (context.Modules.Any())
                {
                    return;   // DB has been seeded
                }

            Module co550 = new Module
            {
                ModuleID = "CO550",
                Title = "Web Applications"
            };

            Module co551 = new Module
            {
                ModuleID = "CO551",
                Title = "Open Source Systems"
            };

            Module co558 = new Module
            {
                ModuleID = "CO558",
                Title = "Database Design"
            };
            context.SaveChanges(true);

            Module co557 = new Module
            {
                ModuleID = "CO557",
                Title = "Software Engineering"
            };

            Module co567 = new Module
            {
                ModuleID = "CO567",
                Title = "Object-oriented Systems Development"
            };

            Module co556 = new Module
            {
                ModuleID = "CO556",
                Title = "Network Systems"
            };

            // Look for courses
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course
                {
                    CourseID = "55900",
                    Title = "Computing",
                    Modules = new List<Module>{ co550, co556, co558, co567, co557, co551 }
                },

            new Course{CourseID="55580",Title="Graphic Design"},
            new Course{CourseID="55660",Title="Art"},
            new Course{CourseID="55560",Title="3D CAD"},
            new Course{CourseID="55670",Title="Cyber Security"},
            new Course{CourseID="55510",Title="Game Devlopment"},
            new Course{CourseID="55570",Title="Engineering"},
            new Course{CourseID="55500",Title="Nursing"}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }

        private static void AddEnrolments(ApplicationDbContext context)
        {
            // Look for any enrollments.
            if (context.Enrollments.Any())
            {
                return;   // DB has been seeded
            }

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=55580,Grade=Grades.A},
            new Enrollment{StudentID=1,CourseID=55660,Grade=Grades.C},
            new Enrollment{StudentID=1,CourseID=55560,Grade=Grades.B},
            new Enrollment{StudentID=2,CourseID=55670,Grade=Grades.B},
            new Enrollment{StudentID=2,CourseID=55510,Grade=Grades.F},
            new Enrollment{StudentID=2,CourseID=55570,Grade=Grades.F},
            new Enrollment{StudentID=3,CourseID=55580},
            new Enrollment{StudentID=4,CourseID=55580},
            new Enrollment{StudentID=4,CourseID=55660,Grade=Grades.F},
            new Enrollment{StudentID=5,CourseID=55560,Grade=Grades.C},
            new Enrollment{StudentID=6,CourseID=55670},
            new Enrollment{StudentID=7,CourseID=55510,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}