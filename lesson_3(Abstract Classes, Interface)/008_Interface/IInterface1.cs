using System;

namespace _008_Interface
{
    #region Liks
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors#static-constructors
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/nested-types
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
    #endregion

    public interface IInterface1
    {
        #region Constants
        const string Language = "C#";
        #endregion

        #region Operators
        public static int operator -(IInterface1 a, int b)
            => b+b;
        #endregion

        #region Static constructor
        static IInterface1()
            => Console.WriteLine("Static constructor from interface");
        #endregion

        #region Nested Types
        public class Nested
        {
            Nested() { }
        }
        #endregion

        #region Static fields
        public static int x = 100;
        #endregion

        #region Methods
        public int DoSomeSomeThing() => 2;
        #endregion

        #region Properties
        public int MyProperty { get; set; }
        #endregion

        #region Indexers
        public IInterface1 this[int i] { get; set; }
        #endregion
    }
}