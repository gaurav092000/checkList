using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
   
   public  class student
    {
       public int id;
        public string name;
        public student()
        {
            Console.WriteLine("Default constrouter");
        }
     public  student(int i,string n)
        {
            id = i;
            name = n;
           
        }
    }
    internal class construtor_overloading
    {
        static void Main()
        {
            student s=new student();
            student student = new student(10, "David");
            Console.WriteLine( "Student Id : " + student.id + "\nStudent Name : " + student.name);
            Console.ReadKey();
        }
    }
}
