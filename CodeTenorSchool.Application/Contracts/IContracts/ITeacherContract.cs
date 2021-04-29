using CodeTenorSchool.Application.DTOs.response;
using System;
using System.Collections.Generic;

namespace CodeTenorSchool.Application.Contracts.IContracts
{
    public interface ITeacherContract
    {
        List<TeacherResponseModel> GetAllTeachers();
        TeacherResponseModel GetTeacherById(Guid teacherId);
        TeacherResponseModel AddTeacher(TeacherRequestModel requestModel);
    }
}
