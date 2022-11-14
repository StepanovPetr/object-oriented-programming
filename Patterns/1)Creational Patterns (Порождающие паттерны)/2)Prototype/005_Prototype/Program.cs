﻿using System;
using LibExample.MemberwiseClone;

namespace _005_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentWithoutMemberwiseClone student = new StudentWithoutMemberwiseClone
            {
                Age = 18,
                FirstName = "Энакин",
                LastName = "Cкайуокер",
                Group = new Group
                {
                    Name = "Group-1",
                    Owner = "оби ван кеноби"
                }
            };

            var clone = (StudentWithoutMemberwiseClone)student.Clone();

            Console.WriteLine($"prototype - {student.GetHashCode()} {Environment.NewLine}clone - {clone.GetHashCode()}");
            Console.WriteLine($"prototype.Group - {student.Group.GetHashCode()} {Environment.NewLine}clone.Group - {clone.Group.GetHashCode()}");

            student.Group.Name = "Group-2";
            Console.WriteLine($"prototype.Group.Name - {student.Group.Name} {Environment.NewLine}clone.Group.Name - {clone.Group.Name}");
        }
    }
}
