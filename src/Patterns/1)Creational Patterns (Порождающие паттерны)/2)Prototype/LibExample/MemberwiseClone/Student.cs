using System;

namespace LibExample.MemberwiseClone
{
    public class Student : ICloneable
    {
        public string LastName  { get; set; }

        public string FirstName { get; set; }

        public int Age  { get; set; }

        public Group Group { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}