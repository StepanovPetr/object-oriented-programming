using System;

namespace LibExample.MemberwiseClone
{
    public class StudentWithoutMemberwiseClone : ICloneable
    {
        public string LastName  { get; set; }

        public string FirstName { get; set; }

        public int Age  { get; set; }

        public Group Group { get; set; }

        public object Clone()
        {
            return new StudentWithoutMemberwiseClone
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                Group = new Group()
                {
                    Name = this.Group.Name,
                    Owner = this.Group.Owner
                }
            };
        }
    }
}