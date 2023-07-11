using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Tlp
    {
        static void Main()
        {
            Thread o1 = new Thread(RunMillitration);
            o1.Start();
        // Parallel.For(0, 1000000, x => RunMillitration());
            Console.ReadLine();
        }
        private static void RunMillitration()
        {
            string x= "";
            for(int iIndex=0;iIndex <1000000;iIndex++)
            {
                x = x + "s";
            }
        }
    }
}
