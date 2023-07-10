using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        
        public int standard { get; set; }

    }
    internal class enumerablr
    {
        static void Main()
        {
            Student s = new Student();  
            s.Id = 1;
            s.Name = "GAURAV";
            s.standard = 10;

            Student s1= new Student();
            s1.Id = 2;
            s1.Name = "Dravid";
            s1.standard = 12;

            Student s2= new Student();
            s2.Id = 3;
            s2.Name = "Kushagra";
            s2.standard = 12;


            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s1);
            students.Add(s2);

            foreach (Student item in students) 
            {
                Console.WriteLine(" "+item.Id   +" "+  item.Name +" "+ item.standard );
            }
            Console.ReadLine();


        }

    }
}
