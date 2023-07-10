using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class2
    {
        static void Main()
        {
            List<int> i = new List<int>();
            i.Add(1);
            i.Add(2);
            foreach (int x in i)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
