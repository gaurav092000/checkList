using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    class passbvalue
    {
        public  passbvalue(int a)
        {
            a = a + 10;
            Console.WriteLine("pass by value : {0} "+a );
        }
    }
    internal class passbyvalue
    {

        static void Main()
        {
            int a=10;
            passbvalue p=new passbvalue(a);
            Console.WriteLine("a :"+a);
            Console.ReadKey();  
            
        }
    }
}
