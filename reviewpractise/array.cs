using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class array
    {
        static void Main()
        {
            int[] array = { 1, 2,45,32,67 };

            Console.WriteLine(" array  before sort");
            foreach( var item in array)
            {
                Console.WriteLine(item);
            }
            Array.Sort(array);
            Console.WriteLine("after sort of array");
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
          
            

        }
    }
}
