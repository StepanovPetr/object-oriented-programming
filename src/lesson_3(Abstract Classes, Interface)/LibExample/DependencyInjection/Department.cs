using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LibExample.DependencyInjection;

/// <summary> Кафедра. </summary>
public class Department : IDepartment
{
    public Student GetStudent(string email)
    {
        List<Student> students = new List<Student>();

        using (var file = File.OpenText("DependencyInjection\\Student.json"))
        {
            // Пример JSON десериализации.
            var serializer = new JsonSerializer();
            students = (List<Student>)serializer.Deserialize(file, typeof(List<Student>));
        }

        return students.FirstOrDefault(s => s.Email == email);
    }
}