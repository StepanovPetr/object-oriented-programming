using LibExample.DependencyInjection;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class DeaneryTests
    {
        [Test]

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
    }
}
