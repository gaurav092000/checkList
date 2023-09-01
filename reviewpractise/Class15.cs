using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class15
    {
        static void Main()
        {
            int n;
            int temp = 0;
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++ )
            {
                for(int j=2;j<=i-1;j++)
                {
                    if(i%j==0)
                    {
                        temp=temp+1;
                    }
                }
                if(temp==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    temp = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
