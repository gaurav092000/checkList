using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class ArrayString
    {
        static void Main()
        {
           int  s;
            Console.WriteLine("Entre the size of string");
            s= int.Parse(Console.ReadLine());
            string[] str = new string[s];

            for(int i=0;i<s;i++)
            {
                Console.WriteLine("Enter the string");
                string str1 =Console.ReadLine();
                str[i]= str1;
            }
            foreach(string str2 in str)
            {
                Console.WriteLine(str2);
            }
            Console.ReadLine();
             
        }
    }
}
