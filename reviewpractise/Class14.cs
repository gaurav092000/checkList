using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class14
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of array");
            n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];

            Console.WriteLine("Enter the arr");
            //int m=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                arr[i] = m;
            }
            for (int i = 0;i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr[i] <arr[j])
                    {
                        int x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                        
                }
            }
            Console.WriteLine("Second Highiest :"+arr[1]);
            Console.ReadLine();
        }
    }
}
