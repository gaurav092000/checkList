using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class7
    {
        static void Main()
        {
            int n, count = 0 ;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());    
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                }

            }
            if(count==2)
            {
                Console.WriteLine("Its a prime ");


            }
            else
            {
                Console.WriteLine("its not a prime number");
            }
            Console.ReadLine    ();

        }
    }
}
