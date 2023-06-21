using System.IO;

namespace _007_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("Example.txt");
            fileInfo.CopyTo("Example.txt.bak");
            fileInfo.CopyTo("ExampleNew.txt.bak");
            fileInfo.CopyTo("ExampleNew.txt.bak", true);
            fileInfo.MoveTo("Example.MoveTo.txt");
        }
    }
}
