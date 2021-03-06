using System.Collections.Generic;

namespace CodeTenorSchool.Entities
{
    public class Student: Person
    {
        public string StudentNo { get; }
        public virtual List<Course> Courses { get; }

        public Student(string studentNo, string name, string surname, int age, string idNo, List<Course> courses = null) : base(name, surname, age, idNo)
        {
            StudentNo = studentNo;

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