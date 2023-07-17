using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    static class product
    {
        public static int productid;
        public static string productname;
        public static int productPrice;

        static product()
        {
            productid = 1;
            productname = "Book";
            productPrice = 1000;
        }

        public static void productdetails()
        {
            Console.WriteLine("product :" +productid);
            Console.WriteLine("product Name :" + productname);
            Console.WriteLine("product price :" + productPrice);
        }

        public  static void getDiscount()
        {
            int discount = productPrice / 10;
            Console.WriteLine("Discount : " + discount);
            Console.WriteLine("Total price of discount product is ",productPrice-discount);

        }
    }

    internal class static1
    {
        static void Main()
        {
            product.productdetails();
            Console.ReadLine();
        }
       
    }
}
