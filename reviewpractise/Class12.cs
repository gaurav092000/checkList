using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class12
    {
      
    
        public static void Main()
        {
            int height = 5; // You can change the height of the pyramid here

            for (int i = 1; i <= height; i++)
            {
                // Print spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
