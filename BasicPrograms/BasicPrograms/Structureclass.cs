using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
 
        struct Book
        {
            public int bid;
            public string bname;
            public int bcost;
        }

    class Structureclass
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.bid = 1;
            b1.bname = "it ends with us";
            b1.bcost = 500;
            Book b2 = new Book();
            b2.bid = 2;
            b2.bname = "it starts with us";
            b2.bcost = 600;
            Book b3 = new Book();
            b3.bid = 3;
            b3.bname = "you are all i need";
            b3.bcost = 400;
            Console.WriteLine("BOOK DETAILS - " + b1.bid + " \n Name : " + b1.bname + " \n cost : " + b1.bcost);
            Console.WriteLine("BOOK DETAILS - " + b2.bid + " \n Name : " + b2.bname + " \n cost : " + b2.bcost);
            Console.WriteLine("BOOK DETAILS - " + b3.bid + " \n Name : " + b3.bname + " \n cost : " + b3.bcost);
            Console.ReadLine();
        }
    }
}
