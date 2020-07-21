using System;
using System.Collections.Generic; 

namespace CMS.UI.Models
{
    public class Course
    {
        public int CourseId;
        public string CourseName;

        public static int MaxSubjects = 8;

        //List<string> list = new List<string>();

        private List<CourseSubject> subjects = null;

        //public property Subjects
        public List<CourseSubject> Subjects
        {
            get
            {
                return subjects;
            }
            private set { subjects = value; }
        }

        public void CalculateFees(decimal electivesFees,
            out decimal finalFees, decimal roughFees = 0)
            {
                //roughFees = 10000;
                finalFees = electivesFees * roughFees;
            }
        public void AddSubject(CourseSubject subject) 
        {
            subjects.Add(subject);

        }

        public void RemoveSubject(CourseSubject subject)
        {
            subjects.Remove(subject);

        }

        public void AddSubject(List<CourseSubject> subjectList)
        {
            subjects.AddRange(subjectList);
        }
        
    }
}