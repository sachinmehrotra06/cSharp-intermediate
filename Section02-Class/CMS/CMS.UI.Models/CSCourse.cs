using System.Collections.Generic;

namespace CMS.UI.Models
{
    public class CSCourse : ICourse
    {
        public List<CourseSubject> Subjects => throw new System.NotImplementedException();

        public int TotalDurationInDays { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddSubject(CourseSubject subject)
        {
            throw new System.NotImplementedException();
        }

        public void AddSubject(List<CourseSubject> subjectList)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveSubject(CourseSubject subject)
        {
            throw new System.NotImplementedException();
        }
    }
}