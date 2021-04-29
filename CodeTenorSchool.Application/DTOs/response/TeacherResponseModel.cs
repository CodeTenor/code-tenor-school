using CodeTenorSchool.Application.ExceptionHandler;
using CodeTenorSchool.Entities;
using Newtonsoft.Json;
using System;

namespace CodeTenorSchool.Application.DTOs.response
{
    public class TeacherResponseModel: ResponseModel
    {
        [JsonProperty("staffNo")]
        public string StaffNo { get; set; }

        [JsonProperty("peronalDetails")]
        public UserResponseModel PersonalDetails { get; set; }

        public TeacherResponseModel(Teacher teacher): base (teacher)
        {
            StaffNo = teacher.StaffNo;
            PersonalDetails = teacher != null ? new UserResponseModel(teacher.User)
                                              : throw new Exception(ExceptionMessages.ErrorRetrievingPersonalInformation);
        }
    }
}
