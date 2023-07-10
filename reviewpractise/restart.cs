using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class restart
    {
        static void Main()
        {
            int n;
            int count = 0;
         
            int i = 1;
           while(true)
            {
                 Console.WriteLine("Enner the numner");
            n = int.Parse(Console.ReadLine());
                if (i<=n)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("prime number");
                }
                else
                {
                    Console.WriteLine("not a prime numbner");
                }
                Console.WriteLine("do you want to continue");
                string c= Console.ReadLine().ToLower();
                if(c=="yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }Console.ReadLine();
        }
    }
}
