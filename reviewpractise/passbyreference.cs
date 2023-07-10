using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class passbvaluee
    {
        public passbvaluee(ref int a)
        {
            a = a + 10;
            Console.WriteLine("pass by value {0} ",  a);
        }
    }
   
    internal class passbyreference
    {
        static void Main()
        {
            int a = 10;
            passbvaluee p = new passbvaluee(ref a);
            Console.WriteLine("a :" + a);
            Console.ReadKey();

        }
    }
}
