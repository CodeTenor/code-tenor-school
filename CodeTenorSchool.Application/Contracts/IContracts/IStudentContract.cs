using System;
using System.Collections.Generic;
using CodeTenorSchool.Application.DTOs.response;

namespace CodeTenorSchool.Application.Contracts.IContracts
{
    public interface IStudentContract
    {
        public List<StudentResponseModel> GetAllStudents();
        public StudentResponseModel GetStudentById(Guid id);
    }
}