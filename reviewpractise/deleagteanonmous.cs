using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{

    public delegate void mycode(int n);
    class programm
    {
        // public static void code(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("A  : "+a);
        //}
    }
    internal class deleagteanonmous
    {
        static void Main()
        {

            mycode m = delegate (int a)
            {
                a = a + 10;
                Console.WriteLine(a);
            };
            m(3);
            Console.ReadLine();
        }
    }
}
