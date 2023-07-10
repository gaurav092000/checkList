using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
     class Rectangle
    {
        int l, b;
        int area;
       public  Rectangle()
        {
            l = 2;
            b = 3;
            area = l * b;
            Console.WriteLine("Area :"+area);

        }
        public void  circle(int r)
        {
            double area;
            area = Math.PI * r * r;
            Console.WriteLine("Area :"+area);
        }
    }
    internal class Construtor
    {
        static void Main(string[] args)
        {
            Rectangle r =new Rectangle();
            int  a=3;
            r.circle(a);
            Console.ReadKey ();

        }
    }
}
