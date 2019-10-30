using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    // Абстрактный класс.
    interface IBuilding
    {
        // Не абстактные члены.
        //public string _ownerName ="Василий";
        //public string _ownerLastName ="Пупкин";

        // Не абстактный метод.
        int Price();

        //public string GetOwner()
        //{
        //    return string.Format("Имя владельца - {0}, Фамилия владельца - {1}", _ownerName , _ownerLastName);
        //}
        int Area
        {
            get ;
           // set ;
        }
        bool LivingRoom
        {
            get;
            //set;
        }        
    }
}
