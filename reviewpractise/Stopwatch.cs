using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Stopwatch
    {
        static void Main()
        {
            System.Diagnostics.Stopwatch sw=new System.Diagnostics.Stopwatch();
            Console.WriteLine("please entre to start");
            Console.ReadKey();
            sw.Start();
            Console.WriteLine("stop watch start");
            Console.ReadKey();

            Console.WriteLine("plz preess enter to stop");
            Console.ReadKey();
            sw.Stop();

           TimeSpan e = sw.Elapsed;
            Console.WriteLine("Elapsed Time: " + e);
            Console.WriteLine("press enter to Exit");
            Console.ReadKey();

        }
    }
}
