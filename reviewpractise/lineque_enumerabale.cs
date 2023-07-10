using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class lineque_enumerabale
    {
        static void Main()
        {
            List<int> number=new List<int> { 11,22,33,44,55};

            var num=from i in number where  i > 44 select i;
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
