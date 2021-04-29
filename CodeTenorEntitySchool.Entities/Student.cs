using System.Collections.Generic;

namespace CodeTenorSchool.Entities
{
    public class Student: DomainEntity
    {
        public string StudentNo { get; }
        public virtual List<Course> Courses { get; }
        public virtual User User { get; set; }

        public Student(string studentNo, User user, List<Course> courses = null)
        {
            StudentNo = studentNo;
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