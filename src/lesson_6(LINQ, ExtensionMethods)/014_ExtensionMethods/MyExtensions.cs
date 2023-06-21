using LibExample;

namespace _014_ExtensionMethods
{
    public static class MyExtensions
    {
        // Пример создания метода расширения для типа string.
        public static string AddSomething(this string str)
        {
            return "!@#$%^&*()" + str + "!@#$%^&*()";
        }

        // Пример создания метода расширения для типа Man.
        public static string AddSomething(this Man man)
        {
            return "!@#$%^&*()" + man.GetType() + "!@#$%^&*()";
        }
    }
}