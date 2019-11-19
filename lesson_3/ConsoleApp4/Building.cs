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
        int Price();
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
