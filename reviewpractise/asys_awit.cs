using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class asys_awit
    {
        static void Main()
        {
           asys_awit.Test1 ();
            asys_awit.Test2();
            asys_awit.Test3();
            asys_awit.Test4();

        }
        public static void Test1()
        {
             Console.WriteLine("Task 1 is starting....");
            Thread.Sleep(2000);
            Console.WriteLine("Task  1 is end");
        }

        public static void Test2()
        {
            Console.WriteLine("Task 2 is starting....");
            Thread.Sleep(4000);
            Console.WriteLine("Task  2 is end");
        }
        public static void Test3()
        {
            Console.WriteLine("Task 3 is starting....");
            Thread.Sleep(5000);
            Console.WriteLine("Task  3 is end");
        }
        public static void Test4()
        {
            Console.WriteLine("Task 4 is starting....");
            Thread.Sleep(1000);
            Console.WriteLine("Task  4 is end");
            Console.ReadLine();
        }
       
    }
   
}
