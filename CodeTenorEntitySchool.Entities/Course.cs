using System.Collections.Generic;

namespace CodeTenorSchool.Entities
{
    public class Course : DomainEntity
    {
        public string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }

        public Course(string name, List<Student> students = null , Teacher teacher = null)
        {
            Name = name;

            if (students == null)
            {
                Students = new List<Student>();
            } 
            else
            {
                Students = students;
            }

            Teacher = teacher;
        }
    }
}
