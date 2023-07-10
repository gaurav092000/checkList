using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class stack1
    {
        static void Main()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sonoo");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("peek Element :"+names.Peek());
            Console.WriteLine("pop element: " + names.Pop());
            Console.WriteLine("After pop,peek Element :" + names.Peek());
            Console.ReadKey();

        }


    }
}

