using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class lamda1
    {
        static void Main()
        {
            List<int> number=new List<int>() { 12,13,14,15,16,17};
            Console.WriteLine(" The List");
            //the list
            foreach(int num in number)
            {
                Console.Write(" "+num);
               
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            //the squre by using lamda
            var square = number.Select(x=>x*x);
            Console.WriteLine(" The square");
            foreach (int value in square)
            {
                Console.Write(" "+value);

            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            //by using lamda find the divisible

            var div = number.FindAll(x=>(x%3)==0);
            Console.WriteLine(" the divisible number by 3");
            foreach (var divisible in div)
            {
                Console.Write(" "+divisible);
            }

            Console.ReadLine();
        }
    }
}
