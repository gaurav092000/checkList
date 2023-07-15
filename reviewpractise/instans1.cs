using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class StudentS
    {
        int id;
        public string FirstName;
       public  string LastName;
        public void printfull()
        {
              string fullName= this.FirstName+" "+this.LastName;
            Console.WriteLine("The Name is :{0}",fullName);
        }
    }


    internal class instans1
    {
        static void Main()
        {
            StudentS student = new StudentS();
            student.FirstName = "Gaurav";
            student.LastName = "Kawde ";
            student.printfull();
            Console.ReadLine();

        }
    }
}
