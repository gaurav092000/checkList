using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class Class6
    {

        int id ;
        string name;
        int age ;
        int standard;

        public  void set(int id,string name,int age, int standard )
        {
            this.id = id;
            this.name = name;   
            this.age = age;
                this.standard = standard;
        }
        public void get()
        {
            Console.WriteLine("Id : {0}",id );
            Console.WriteLine("Name :{0}", name);
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine("standard : {0}", standard);
        }
        public static void Main()
        {
            Class6 c=new Class6();
            c.set(1,"Gaurav",22,1);
            c.get();
            Console.ReadLine();
            
        }
    }
}
