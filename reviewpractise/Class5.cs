using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class Bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public string balance{ get; set; }
    


    }
   class emp:Bank
    { 
        public void show(int id)
        {
            Console.WriteLine(id);
        }
        public void show(string name)
        {
            Console.WriteLine(name);
        }
        public void show(double balance)
        {
            Console.WriteLine(balance);
        }

    }
    internal class Class5
    {

        static void Main()

        {
            emp e=new emp();
            int n;
            string name;
            Console.WriteLine("Enter the id ");
            n=int.Parse(Console.ReadLine());
            e.show(n);
            Console.WriteLine("Enter the Name of Account ");
            name=Console.ReadLine();
            e.show(name);

            Console.ReadLine();
        }

    }
}
