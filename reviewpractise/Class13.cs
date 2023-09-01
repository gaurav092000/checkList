using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class13
    {
        static void Main(String[] agr)
        {
           int[] arr = {12,34,45,65,78 };
            
            int n= arr.Length;

            Array.Sort(arr);

            Console.WriteLine("sECOND EMENT:" + arr[n - 2]);
            Console.ReadLine();
        }

    }
}
