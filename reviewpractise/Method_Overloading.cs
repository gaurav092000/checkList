using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class overLoading
    {
       public  int a;
        public string name;
       public  void display()
        {
            Console.WriteLine("Default");
        }
       public  void display(int i)
        {
            a = i;
            
        }
       public  void display(string n)
        {
            name = n;
        }
    }
    internal class Method_Overloading
    {
        static void Main()
        {
            overLoading vr=new overLoading();
            vr.display();
            vr.display(1);
            Console.WriteLine("id :"+vr.a);
            vr.display("Practise");
            Console.WriteLine("Book :"+vr.name);
            Console.ReadKey();
        }
    }
}
