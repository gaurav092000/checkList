using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class JUMP
    {
        static void Main()
        {
            for (int i = 0; i <= 10; i++) 
            {
                if(i%2==1)
                {
                    continue;

                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
