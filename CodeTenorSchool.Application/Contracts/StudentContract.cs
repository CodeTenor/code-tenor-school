using System;
using System.Collections.Generic;
using System.Linq;
using CodeTenorSchool.Application.Contracts.IContracts;
using CodeTenorSchool.Entities;
using CodeTenorSchool.Application.DTOs.response;
using CodeTenorSchool.DataAccess.Repositories;
using CodeTenorSchool.Application.ExceptionHandler;

namespace CodeTenorSchool.Application.Contracts
{
    public class StudentContract: IStudentContract
    {

        private readonly IRepository<Student> _studentRepository;
        private readonly ICodeTenorSchoolDBContext _context;

        public StudentContract(IRepository<Student> studentRepository,
                                ICodeTenorSchoolDBContext context)
        {
            _studentRepository = studentRepository;
            _context = context;
        }

        public List<StudentResponseModel> GetAllStudents()
        {
            List<Student> students = _studentRepository.GetAll().ToList();

            return students.Select(u => new StudentResponseModel(u)).ToList();
        }

        public StudentResponseModel GetStudentById(Guid id)
        {
            Student student = _studentRepository.GetById(id);

            if (student == null)
            {
                throw new Exception(ExceptionMessages.StudentNotFound);
            }

            return new StudentResponseModel(student);
        }
    }
}