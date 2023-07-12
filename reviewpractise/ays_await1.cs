using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class ays_await1
    {
        static void Main()
        {
          Test1();
           Test2();
           Test3();
           Test4();
            Console.ReadLine();

        }
        public static async void Test1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 is starting....");
                Thread.Sleep(2000);
                Console.WriteLine("Task  1 is end");

            });
            
        }

       
        public static async void Test2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 is starting....");
                Thread.Sleep(4000);
                Console.WriteLine("Task  2 is end");

            });

        }
        public static async void Test3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 is starting....");
                Thread.Sleep(5000);
                Console.WriteLine("Task  3 is end");

            });

        }
        public static async void Test4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 is starting....");
                Thread.Sleep(1000);
                Console.WriteLine("Task  4 is end");
                
            });
         
        }


    }
}
