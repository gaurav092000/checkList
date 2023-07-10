using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class passbyoutt
    {
        public static void PassByOut(out int a)
        {
            a = 10;
            Console.WriteLine("A : {0}",a);
        }
    }
    internal class passbyout
    {
        static void Main()
        {
            int a;
           passbyoutt.PassByOut(out a);
            Console.WriteLine("a  :" +a);
            Console.ReadKey();
           
        }
    }
}
