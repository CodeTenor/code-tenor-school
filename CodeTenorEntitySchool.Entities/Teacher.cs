using System.Collections.Generic;

namespace CodeTenorSchool.Entities
{
    public class Teacher: Person
    {
        public string StaffNo { get; }
        public virtual List<Course> Courses { get; }

        public Teacher(string staffNo, string name, string surname, int age, string idNo, List<Course> courses = null) : base(name, surname, age, idNo)
        {
            StaffNo = staffNo;

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
