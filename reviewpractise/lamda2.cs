using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class lamda2
    {
        //order of name from list
        static void Main()
        {
            List<students> std = new List<students>()
            {
                new students{ id= 1,name= "Gaurav" },
                new students{ id= 4,name= "Ramesh" },
                new students{ id= 3,name= "Mahesh" },
                new students{ id= 2,name= "Rajesh" }
            };
            foreach (students student in std) 
            {
            Console.WriteLine("ID : {0}, Name : {1} ",student.id,student.name);
            }
            Console.WriteLine("-----------------------------------------------");
            var arranged = std.OrderBy(x=>x.id);

            foreach (students stdd in arranged)
            {
                Console.WriteLine("ID : {0}, Name : {1} ", stdd.id, stdd.name);
            }
            Console.ReadLine();
        }

    }
    class students
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
