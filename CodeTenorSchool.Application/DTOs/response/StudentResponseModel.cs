using CodeTenorSchool.Entities;
using System;

namespace CodeTenorSchool.Application.DTOs.response
{
    public class StudentResponseModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public StudentResponseModel(Student student)
        {
            id = student.Id;
            name = student.Name;
            surname = student.Surname;
            this.age = student.Age;
        }
    }
}