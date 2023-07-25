using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class11
    {
        static void Main()
        {
            string str;
            str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string a = new string(arr);
            Console.WriteLine(a);
            Console.ReadLine();



        }
    }
}
