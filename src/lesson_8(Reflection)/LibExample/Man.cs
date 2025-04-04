﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibExample
{
    [System.Serializable()]
    public class Man
    {
        #region private fields
        private int _age;
        #endregion

        #region static fields
        static string[] _firstNames = new string[] { "Вова", "Алексей", "Егор", "Дима", "Николай", "Петр", "Максим", "Иван" };
        static string[] _secondNames = new string[] { "Мусихин", "Цыганок", "Чердынцев", "Степанов", "Куянов", "Атинк", "Максим", "Блинов" };
        static string[] _cities = new string[] { "Омск", "Москва", "Хацупетовка" };
        static Random _rand = new Random();
        #endregion

        #region public fields
        public string FirstName;
        public string SecondName;
        public int Age;
        #endregion

        #region   Constructors
        // Конструктор по умолчанию
        public Man()
        {
            this.FirstName = "Энакин";
            this.SecondName = "Скайуокер";
            this.Age = 33;
        }

        // Конструктор с параметрами
        public Man(string firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        #endregion

        #region static metods
        public static Man GetMan()
        {
            return new Man()
            {
                FirstName = _firstNames[_rand.Next(0, _firstNames.Length)],
                SecondName = _secondNames[_rand.Next(0, _secondNames.Length)],
                City = _cities[_rand.Next(0, _cities.Length)],
                Age = _rand.Next(1, 101)
            };
        }
        #endregion

        #region public metods
       

        public string ManInfo()
        {
            return string.Format($"FirstName - {FirstName} SecondName - {SecondName} Age - {_age} Hash - {GetHashCode()}");

        }

        // значение переменной по умолчанию.
        public string ManInfoWithPlanet(string planet = "Татуин")
        {
            return string.Format("FirstName - {0} SecondName - {1} Age - {2} Planet - {3}", this.FirstName, this.SecondName, this.Age, planet);
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            //return string.Format($"FirstName - {this.FirstName} SecondName - {this.SecondName} Age - {this.Age}");
        }
        #endregion

        #region public metods
        private string examplePrivateMethod(string strginParam, int numParam, bool boolParam)
        {
            return $"{strginParam}  {numParam}  {boolParam}";
        }

        #endregion

        #region public property
        public string City { get; set; }
        #endregion
    }
}
