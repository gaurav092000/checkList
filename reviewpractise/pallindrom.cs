using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class pallindrom
    {
        static void Main()
        {
            int n;
            int s = 0;
            n=int.Parse(Console.ReadLine());
            int c = n;
            while(n>0)
            {
                int r = n % 10;
                 s = (s * 10) + r;
                n = n / 10;
            }
            if(s==c)
            {
                Console.WriteLine("palindrm");
            }
            else
            {
                Console.WriteLine("not ");

            }
            Console.ReadLine();
        }
    }
}
