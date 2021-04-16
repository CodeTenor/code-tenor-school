using AutoFixture;
using CodeTenorSchool.Application.Contracts;
using CodeTenorSchool.Application.ExceptionHandler;
using CodeTenorSchool.DataAccess.Repositories;
using CodeTenorSchool.Entities;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CodeTenorSchool.UnitTets
{
    public class StudentContractUnitTests
    {
        private readonly StudentContract _sut;
        private readonly IRepository<Student> _studentRepository = Substitute.For<IRepository<Student>>();
        private readonly ICodeTenorSchoolDBContext _context = Substitute.For<ICodeTenorSchoolDBContext>();
        private readonly IFixture _fixture = new Fixture();

        public StudentContractUnitTests()
        {
            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                             .ForEach(b => _fixture.Behaviors.Remove(b));

            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _sut = new StudentContract(_studentRepository, _context);
        }

        [Fact]
        public void GetAllStudents_ShouldReturnListOfStudentResponseModel()
        {
            // Arrange
            List<Student> students = _fixture.Build<List<Student>>()
                                             .Create();


            _studentRepository.GetAll().Returns(students);

            // Act
            var response = _sut.GetAllStudents();

            // Assert
            Assert.Equal(students.Count(), response.Count());
        }

        [Fact]
        public void GetStudentById_ShouldReturnNull_WhenInvalidStudentIdParsed()
        {
            // Arrange
            const string studentId = "4a4c8b03-c86e-46d8-964c-3eb0ea93dc8e";

            _studentRepository.GetById(new Guid(studentId)).ReturnsNull();

            // Act
            var result = Assert.Throws<Exception>(() => _sut.GetStudentById(new Guid(studentId)));

            // Assert
            Assert.Equal(ExceptionMessages.StudentNotFound, result.Message);
        }

        [Fact]
        public void GetStudentById_ShouldReturnStudentResponseModel_WhenValidStudentIdParsed()
        {
            // Arrange
            const string studentId = "4a4c8b03-c86e-46d8-964c-3eb0ea93dc8e";

            Student student = _fixture.Build<Student>()
                                      .Create();

            _studentRepository.GetById(new Guid(studentId)).Returns(student);

            // Act
            var result = _sut.GetStudentById(new Guid(studentId));

            // Assert
            Assert.Equal(result.id, student.Id);
        }
    }
}
