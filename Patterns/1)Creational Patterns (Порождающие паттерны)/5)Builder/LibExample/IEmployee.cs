using LibExample.Enums;

namespace LibExample
{
    public interface IEmployee
    {
        string FirstName {get;}
        
        string LastName {get;}

        Department Department {get;}

        string ManagerName { get;}

        Position Position { get; }
    }
}
