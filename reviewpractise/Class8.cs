using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class8
    {
        static void Main()
        {
            int[] arr = {16,32,3,48,50,6,87 };
            int max = 0;
            int second = 0;
            int third = 0;

            foreach (int n in arr)

            {
                if (max < n)
                {
                    third = second;
                    second = max;
                    max = n;
                }
                else if (second < n)
                {
                    second = third;
                }
                else if (third < n)
                {
                    third = n;
                }
            }
            Console.WriteLine("First :"+max);
            Console.WriteLine("Second :" +second);
            Console.WriteLine("third :" +third);
            Console.ReadLine();
        }
    }
}
