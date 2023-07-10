using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class parent
    {
        public virtual void show()
        {
            Console.WriteLine("it si a parent class");
        }
    }
    class child : parent
    {
        public override void show()
        {
            Console.WriteLine("it is child claasss");
        }
    }
    internal class Methoadoverring
    {
        static void Main()
        {
            parent p=new child();
            p.show();
            Console.ReadKey();
        }
    } 
}
