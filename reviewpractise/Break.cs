using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Break
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++) 
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
