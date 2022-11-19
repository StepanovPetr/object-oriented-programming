using System;
using LibExample.Enums;

namespace LibExample
{
    public class LogicExample
    {
        public int GetSalary(IEmployee employee)
        {
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                throw new ArgumentException("FirstName not set");
            }

            if (string.IsNullOrEmpty(employee.LastName))
            {
                throw new ArgumentException("LastName not set");
            }

            if (string.IsNullOrEmpty(employee.ManagerName))
            {
                throw new ArgumentException("ManagerName not set");
            }

            if (employee.Department == Department.Other)
            {
                return 400;
            }

            switch (employee.Position)
            {
                case Position.Junior: return 500;
                case Position.Middle: return 1000;
                case Position.Senior: return 2000;

                default: throw new ArgumentException("Key not found");
            }
        }
    }
}