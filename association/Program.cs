using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseCode = "CS101";
            course1.CourseTitle = "Introduction to Computer Science";
            course1.Credits = 3;

            Course course2 = new Course();
            course2.CourseCode = "CS102";
            course2.CourseTitle = "Data Structures";
            course2.Credits = 4;

            Course course3 = new Course();
            course3.CourseCode = "CS103";
            course3.CourseTitle = "Algorithms";
            course3.Credits = 5;

            Department department = new Department();
            department.DepartmentCode = "CSE";
            department.DepartmentName = "Computer Science";
            department.Courses.Add(course1);
            department.Courses.Add(course2);
            department.Courses.Add(course3);
            Console.WriteLine($"Department: {department.DepartmentName} ({department.DepartmentCode})");

        }
    }
}
