using System;
using System.Collections.Generic;
using CodeTenorSchool.Application.Contracts.IContracts;
using CodeTenorSchool.Application.DTOs.response;
using Microsoft.AspNetCore.Mvc;

namespace CodeTenorSchool.Controllers
{
    [ApiController]
    [Route("api/v1/student")]
    public class StudentController: ControllerBase
    {
        private readonly IStudentContract studentContract;

        public StudentController(IStudentContract studentContract)
        {
            this.studentContract = studentContract;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllStudents()
        {
            List<StudentResponseModel> response = studentContract.GetAllStudents();

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStudentById(string id)
        {
            StudentResponseModel response = studentContract.GetStudentById(new Guid(id));

            return Ok(response);
        }
    }
}