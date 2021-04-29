using System.Collections.Generic;

namespace CodeTenorSchool.Entities
{
    public class Teacher: DomainEntity
    {
        public string StaffNo { get; }
        public virtual List<Course> Courses { get; }
        public virtual User User { get; set; }

        public Teacher(string staffNo, User user, List<Course> courses = null)
        {
            StaffNo = staffNo;
            User = user;

            if (courses == null)
            {
                Courses = new List<Course>();
            }
            else
            {
                Courses = courses;
            }
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }
    }
}
