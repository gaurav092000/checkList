using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class Students
        {

        public int id  { get; set; }
        public string name { get; set; }

        public int standard { get; set; }

        
        
    }
    class School : IEnumerable
    {
        List<Student> students = new List<Student>();

        public void Add(Student s)
        {
            students.Add(s);
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
    internal class enumerable1
    {
        static void Main()
        {
     
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "GAURAV";
            s1.standard = 10;

            Student s2 = new Student();
            s2.Id = 2;
            s2.Name = "Dravid";
            s2.standard = 12;

            Student s3 = new Student();
            s3.Id = 3;
            s3.Name = "Kushagra";
            s3.standard = 12;

            School s = new School();
            s.Add(s1);
            s.Add(s2);
            s.Add(s3);

            foreach(Student ss in s)
            {
                Console.WriteLine(" " + ss.Id + " " + ss.Name + " " + ss.standard);
            }
            Console.ReadLine();
        }
    }
}
