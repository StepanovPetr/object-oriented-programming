using System;
using LibExample.DependencyInjection;
using LibExample.DependencyInjection2;

namespace _009_DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            //department.GetStudent("ivan.ivanov@example.com");

            Deanery deanery = new Deanery(department);
            deanery.SetStudentnetAssessment("ivan.ivanov@example.com");

            OmGTU omgtu = new OmGTU();
            Console.WriteLine(omgtu.IsOpen());

            OmGTUFix omgtuFix = new OmGTUFix(new DateTimeManager());
            Console.WriteLine(omgtuFix.IsOpen());


            Console.WriteLine("Hello World!");
        }
    }
}
