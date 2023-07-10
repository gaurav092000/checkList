using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class stringBuilder
    {
        static void Main()
        { 
            StringBuilder sb = new StringBuilder("Gaurav");
            sb.Append(" Kawde");
            Console.WriteLine("NAme :"+sb);
            Console.ReadKey();
        }
    }
}
