using System;
using LibExample;
using LibExample.Builders;
using LibExample.Enums;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class LogicExampleTestsWihtEmployeeBuilderSecond
    {
        [TestCase()]
        public void GetSalarySenior()
        {
            //Arrange.
            LogicExample logicExample = new LogicExample();
            var employee = EmployeeBuilderSecond
                .CreateCorrectBuilder()
                .Build();

            //Act.
            var result =  logicExample.GetSalary(employee);

            //Assert.
            Assert.AreEqual(result, 2000);
        }

        [TestCase()]
        public void GetSalaryMiddle()
        {
            //Arrange.
            LogicExample logicExample = new LogicExample();
            var employee = EmployeeBuilderSecond
                .CreateCorrectBuilder()
                .SetPosition(Position.Middle)
                .Build();

            //Act.
            var result = logicExample.GetSalary(employee);

            //Assert.
            Assert.AreEqual(result, 1000);
        }

        [TestCase()]
        public void GetSalaryJunior()
        {
            //Arrange.
            LogicExample logicExample = new LogicExample();
            var employee = EmployeeBuilderSecond
                .CreateCorrectBuilder()
                .SetPosition(Position.Junior)
                .Build();

            //Act.
            var result = logicExample.GetSalary(employee);

            //Assert.
            Assert.AreEqual(result, 500);
        }

        [TestCase()]
        public void GetSalaryFirstNameNotSet()
        {
            //Arrange.
            LogicExample logicExample = new LogicExample();
            var employee = EmployeeBuilderSecond
                .CreateCorrectBuilder()
                .SetFirstName(null)
                .Build();

            //Act.
            var ex = Assert.Throws<ArgumentException>(() => logicExample.GetSalary(employee));

            //Assert.
            Assert.AreEqual(ex.Message, "FirstName not set");
        }

        [TestCase()]
        public void GetSalaryLastNameNotSet()
        {
            //Arrange.
            LogicExample logicExample = new LogicExample();
            var employee = EmployeeBuilderSecond
                .CreateCorrectBuilder()
                .SetLastName(null)
                .Build();

            //Act.
            var ex = Assert.Throws<ArgumentException>(() => logicExample.GetSalary(employee));

            //Assert.
            Assert.AreEqual(ex.Message, "LastName not set");
        }

        [TestCase()]
        public void GetSalaryManagerNameNotSet()
        {
            //Arrange.
            LogicExample logicExample = new LogicExample();
            var employee = EmployeeBuilderSecond
                .CreateCorrectBuilder()
                .SetManagerName("")
                .Build();

            //Act.
            var ex = Assert.Throws<ArgumentException>(() => logicExample.GetSalary(employee));

            //Assert.
            Assert.AreEqual(ex.Message, "ManagerName not set");
        }
    }
}
