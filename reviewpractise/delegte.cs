using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    public delegate void cal(int a, int b);
    class program
    {
        public static void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addtion :" + c);
        }
        public static void sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Substraction :" + c);
        }
    }
    internal class delegte
    {
        static void Main()
        {
            cal c = new cal(program.add);
            c.Invoke(10, 20);
            c = program.sub;
            c(20, 30);
            Console.ReadKey();
        }
    }
}

