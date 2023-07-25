using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class person
    {
        private string name;
        private  int age;

        public void setter(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void  Getter()
        {
            Console.WriteLine("Name :"+this.name);
            Console.WriteLine("Age :" + this.age);

        }

    }
    internal class encapsulation
    {
        static void Main()
        {
            person p = new person();
            p.setter("Gaurav", 1);
            p.Getter();
        
            Console.ReadLine();
        }
    }
}
