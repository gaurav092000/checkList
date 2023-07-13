using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class Class1
    {
        static void Main(string[] args)
        {
            var list = new List<ABC>();

            var list1 = new List<XYZ>();
            list1.Add(new XYZ { Name = "1" });
            list1.Add(new XYZ { Name = "2" });
            list1.Add(new XYZ { Name = "3" });

            list.Add(new ABC { Id = 1, xyzList = list1 });

            //foreach (var item in list1)
            //{
            //    item1 = item.Name = item.Name.Contains("3") ? "5" : item.Name;
            //}

            //Console.WriteLine(item1);

            //  list1.Contains(new XYZ { Name = "3" }) ? "5"
            //  
            //list1[2] = new XYZ { Name = "5" };
            //Console.WriteLine(list1[2]);
        
            foreach (var item in list1) 
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("===================");

            list1[2].Name = "5";
            foreach (var itemm in list1)
            {
                Console.WriteLine(itemm.Name);
            }

            Console.ReadLine();
        }
    }

    public class XYZ
    {
        public string Name { get; set; }
    }

    public class ABC
    {
        public int Id { get; set; }
        public List<XYZ> xyzList { get; set; }
    }


}
