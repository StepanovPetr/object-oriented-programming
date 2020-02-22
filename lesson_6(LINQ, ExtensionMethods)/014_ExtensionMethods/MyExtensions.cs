using System;

namespace _014_ExtensionMethods
{
    public static class MyExtensions
    {
        // Пример создания метода использования для типа string.
        public static string AddSomthing(this String str)
        {
            return "!@#$%^&*()" + str + "!@#$%^&*()";
        }
    }
}