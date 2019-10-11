using System;
using System.IO;
using Serialize_03;
using NUnit.Framework;

namespace _17_NUnit_4
{
    public class Class1
    {
        //Install-Package NUnit -Version 3.12.0 

        //Выполняется один раз перед запуском всех тестов.
        [OneTimeSetUp]
        public void SetUp()
        {
            Man man = new Man();
            man.Age = 135;
            man.FirstName = "Вася";
            man.SecondName = "Пупкин";
            man.BinarySerialization("Example.bin");
            man.JsonSerialization("Example.json");
        }

        //Выполняется один раз после запуска всех тестов.
        [OneTimeTearDown]
        public void TearDown()
        {
            if (File.Exists("Example.bin"))
                File.Delete("Example.bin");
            if (File.Exists("Example.json"))
                File.Delete("Example.json");
        }

        [Test]
        public void BinaryDeserializationTest()
        {
            Man man = Man.BinaryDeserialization("Example.bin");
            Assert.NotNull(man);
        }

        [Test]
        public void JsonDeserializatioTest()
        {
            Man man = Man.JsonDeserialization("Example.json");
            Assert.NotNull(man);
        }

    }
}
