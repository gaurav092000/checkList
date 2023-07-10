using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class arryinput
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of array");
            n=int.Parse(Console.ReadLine());

            int [] arr=new int[n];

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the elelment in array");
                int num=int.Parse(Console.ReadLine());
                arr[i]=num;
            }
            Console.WriteLine("----------------------yOUR OUT PUT-----------------------");

            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
