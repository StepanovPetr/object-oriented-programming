using LibExample.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class DeaneryTests
    {
        [Test(Description = "")]
        public void Deanery_ObjectOrientedProgramming_ShouldEqualOrMore90()
        {
            // Arrange.
            DepartmentMock departmentMock = new DepartmentMock();
            Deanery deanery = new Deanery(departmentMock);

            // Act.
            var student = deanery.SetStudentnetAssessment("");

            //Assert.
            Assert.That(student.Scholarship, Is.EqualTo(100000));
        }

        [Test(Description ="")]
        public void Deanery_OperatingSystems_ShouldEqualOrMore90()
        {
            // Arrange.
            Mock<IDepartment> departmentMock = new();
            departmentMock.Setup(m => m.GetStudent(It.IsAny<string>()))
                .Returns(new Student()
            {
                OperatingSystems = 90
            });

            Deanery deanery = new Deanery(departmentMock.Object);

            // Act.
            var student = deanery.SetStudentnetAssessment("");

            //Assert.
            Assert.That(student.Scholarship, Is.EqualTo(100000));
        }
    }
}
