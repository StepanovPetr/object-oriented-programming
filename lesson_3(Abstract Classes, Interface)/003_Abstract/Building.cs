﻿using _003_Abstract.Enums;

namespace _003_Abstract
{
    // Абстрактный класс.
    abstract class Building : Place
    {
        // Не абстактные члены.
        public string _ownerName = "Василий";
        public string _ownerLastName = "Пупкин";

        // Не абстактный метод.
        public abstract int Price(int value);

        public override City City
        {
            get;
            set;
        }

        public string GetOwner()
        {
            return $"Имя владельца - {_ownerName}, " +
                $"Фамилия владельца - {_ownerLastName}";
        }
        public abstract int Area
        {
            get;
        }
        public abstract bool LivingRoom
        {
            get;
        }
    }
}