using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class VisitingEmp:Employee
    {
        public double visitingSalary;
        public int visitingHour;

    }
    class paramanentEmp :Employee
    {

        public double parmanentSalary;
        public int parmanentHour;

    }
    class Employee
    {
        public int Empid;
        public string Empname;
        public int Empage;
        public int EmpContact;
       
        public void show()
        {
            Console.WriteLine("It is a base class method");
        }

    }
    internal class in1
    {
        static void Main()
        {
            paramanentEmp emp = new paramanentEmp();
            emp.Empid = 1;
            emp.show();
            Console.WriteLine(emp.Empid);
            Console.ReadLine();
        }
    }
}
