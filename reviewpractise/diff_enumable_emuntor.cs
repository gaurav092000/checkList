using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class diff_enumable_emuntor
    {
        static void Main()
        {
            List<int> number = new List<int> { 11, 22, 33, 44, 55 };

            foreach (int i in number) 
            {
                Console.WriteLine(i);
             }


            Console.WriteLine("---------------------------------");


            IEnumerator<int> nums= number.GetEnumerator();

            while (nums.MoveNext()) 
            {
                Console.WriteLine(nums.Current.ToString());
            }
            Console.ReadLine();

        }
    }
}
