using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{


    class sum
    {
        int a, b;
        public sum(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void add()
        {
            Console.WriteLine("Sum is" + (a + b));
        }
    }
    class thiskeyword
    {

        static void Main(string[] args)
        {
            sum s = new sum(100, 200);
            s.add();
            Console.ReadLine();
        }
    }
}
