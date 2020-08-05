using System;

namespace CMS.UI.Models
{

    public class Student : IStudent
    {
        //Class fields
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }

        public int StudentId = 123444;

        //readonly field
        public readonly int maxCourse = 3;
  
        //Static field
        public static int maxBooksAllowedPerStudent = 6;

        //student Constructor
        public Student()
        {
            Console.WriteLine("Called Student Constructor");
            // All initializations goes here. 
        }

        public Student(string firstName, string secondName, int studentId)
        {
            Console.WriteLine("Student(string FirstName, string LastName, int StudentId )");
            FirstName = firstName;
            StudentId = studentId;
            LastName = LastName;
        }

        //Destructor
        ~Student()
        {
            //Currently nothing has to do
        }

        public int GetId()
        {
            return StudentId;
        }
    }
}
