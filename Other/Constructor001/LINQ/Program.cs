using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
  
            List<string> list = new List<string>();
            list = File.ReadAllLines("2.txt").ToList();

            var filter = list.Where(x => x != "a");
            filter = filter.Where(x => x != "b");
            filter = filter.OrderByDescending(x => x).ToList();

            string totalString = null;
            int count = 0;
            foreach (string itel in filter)
                count++;

            var comeNew = filter.First() + filter.Last();

            DateTime stopTime = DateTime.Now;
            TimeSpan timeWorked = new TimeSpan();
            timeWorked = stopTime - startTime;

            Console.WriteLine(string.Format("{0:0}:{1:00}", (int)timeWorked.Seconds, timeWorked.Milliseconds));
            Console.ReadLine();
        }
    }
}
