using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class dynamiccprgm
    {
        static void Main(string[] args)
        {
            var a = 100;
            Console.WriteLine(a);
            a = 30;
            Console.WriteLine(a);
            dynamic x1 = 100;
            x1 = 30;
            Console.WriteLine(x1);
            dynamic x2 = "chandu";
            Console.WriteLine(x2);
            dynamic x3 = 100.7f;
            Console.WriteLine(x3);
            dynamic x4 = 'h';
            Console.WriteLine(x4);
            Console.ReadLine();

        }
    }
}
