using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class gototo
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i==5)
                {
                    goto stop;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop exit");
            stop:
            Console.WriteLine("hello");
            Console.ReadLine();

        }
    }
}
