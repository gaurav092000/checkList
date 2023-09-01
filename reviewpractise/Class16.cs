using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    public delegate int ddelegate(int n);
    internal class Class16
    {
        public static void Main()
        {
            ddelegate obj = (a) => a * a;
            Console.WriteLine(obj(5));
            Console.ReadLine();
        }
       
    }
}
