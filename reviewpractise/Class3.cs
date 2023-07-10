using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class3
    {
        static void Main()
        {
            int n;
            string ch;
            int count =0;

            do
            {
                Console.WriteLine("Enter the number");
                n=int.Parse(Console.ReadLine());
                for(int i = 1; i <=n;i++)
                {
                       if(n%i==0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine("it a prime nuimber");
                }
                else
                {
                    Console.WriteLine("it is not a prime number");
                }
                Console.WriteLine("Do you want to continue YEs/no");
                ch=Console.ReadLine().ToLower();
            }
            while (ch=="yes");
            Console.ReadLine(); 
        }
    }
}
