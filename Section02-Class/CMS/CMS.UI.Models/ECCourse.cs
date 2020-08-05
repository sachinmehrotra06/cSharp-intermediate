using System.Collections.Generic;

namespace CMS.UI.Models
{
    public class ECCourse : ICourse
    {
        List<CourseSubject> ICourse.Subjects => throw new System.NotImplementedException();

        int ICourse.TotalDurationInDays { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        void ICourse.AddSubject(CourseSubject subject)
        {
            throw new System.NotImplementedException();
        }

        void ICourse.AddSubject(List<CourseSubject> subjectList)
        {
            throw new System.NotImplementedException();
        }

        void ICourse.RemoveSubject(CourseSubject subject)
        {
            throw new System.NotImplementedException();
        }
    }
}