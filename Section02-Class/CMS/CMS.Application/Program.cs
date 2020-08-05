using System;
using CMS.UI.Models;
using CMS.UI.Display;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object instantiation
            Student student = new Student();
            Staff staff = new Staff();
            Course computerScience = new Course();

            //direct instantiation
            Student student1 = new Student()
            {
                FirstName = "Ritu",
                LastName = "Mehrotra",
                StudentId = 201
            };

            //assignment and print
            student.FirstName = "John";
            Console.WriteLine(student.FirstName);
            

            
            Console.WriteLine(student1.FirstName);
            Console.WriteLine(student1.LastName);
            Console.WriteLine(student1.StudentId); 
            Console.WriteLine(student1.maxCourse);    
            Console.WriteLine(Student.maxBooksAllowedPerStudent);

            Console.WriteLine("refrence example");
            student = student1;
            Console.WriteLine(student1.FirstName);
            Console.WriteLine(student.FirstName);
            staff.FirstName = "Sachin";

            computerScience.CourseId = 2;
            computerScience.CourseName = "CSE";
            Console.WriteLine(computerScience.CourseId + computerScience.CourseName);
            Console.WriteLine(computerScience.CourseName);

            //Methods example
            Student student2 = new Student()
            {
                FirstName = "Ritu",
                LastName = "Mehrotra",
                StudentId = 333
            };

            Console.WriteLine(student2.GetId() );

            //Constructors and Destructors
            Student student3 = new Student();
            Student student4 = new Student("San", "Meh", 22);

            Display.Show(student3.FirstName);
            Display.Show(student4.FirstName);
            //properties

            Staff staff1 = new Staff();
            string name = staff1.FirstName;
            Console.WriteLine(name);
            name = staff1.LastName;
            Console.WriteLine(name);
            


            //static class
            Display.Show("Sachin");


            //Interface
            ICourse csCourse = new CSCourse();
            ICourse ecCourse = new ECCourse();

            Console.WriteLine(csCourse.GetTotalElectives());
            Console.WriteLine(ecCourse.GetTotalElectives());




        }
    }
}
