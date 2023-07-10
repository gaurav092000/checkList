
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    public delegate int  Mydelegate(int a);
    internal class lamda
    {
        static void Main()
        {
            Mydelegate ob = (a) => a * a;

            Console.WriteLine(ob(5));
            Console.ReadLine();

        }
    }
}
