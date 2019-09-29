using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Operators
{
    class Man
    {
        #region private fields
        private string _firstName;
        private string _secondName;
        private int _age;
        #endregion

        #region   Constructors
        //Конструктор по умолчанию
        public Man()
        {
            this._firstName = "Валерий";
            this._secondName = "Кипелов ";
            this._age = 0;
        }

        //Конструктор с параметрами
        public Man(string firstName, string secondName, int age)
        {
            this._firstName = firstName;
            this._secondName = secondName;
            this._age = age;
        }
        #endregion

        #region public properties
        //Примеры использования Свойств
        public string FirstName
        {
            get
            {
                if (_firstName == "")
                    return "В поле отсутствуют данные.";
                else
                    return _firstName;
            }
            set { _firstName = value; }
        }

        public string SecondName
        {
            get
            {
                if (_secondName == "")
                    return "В поле отсутствуют данные.";
                else
                    return _secondName;
            }
            set { _secondName = value; }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }
        #endregion

        #region public metods
        public string ManInfo()
        {
            return string.Format("FirstName - {0} SecondName - {1} Age - {2}", this._firstName, this.SecondName, this.Age);         
        }
        #endregion

        public static bool operator == (Man firstMan, Man secondMan)
        {
            return ((firstMan.Age == secondMan.Age) && (firstMan.FirstName == secondMan.FirstName) && (firstMan._secondName == secondMan._secondName)) ? true : false;
        }

        public static bool operator != (Man firstMan, Man secondMan)
        {
            return ((firstMan.Age == secondMan.Age) && (firstMan.FirstName == secondMan.FirstName) && (firstMan._secondName == secondMan._secondName)) ? false : true;
        }
    }
}
