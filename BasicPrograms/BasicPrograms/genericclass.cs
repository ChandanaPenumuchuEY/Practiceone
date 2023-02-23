using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class X<A>
    {
        public A v;
        public X(A v)
        {
            this.v = v;
            Console.WriteLine(v);
        }
    }
    class genericclass
    {
        static void swap<T>(ref T a,ref T b)
        {
            T res = default(T);
            res = a;
            a = b;
            b = res;
            Console.WriteLine("a : "+a+" b : "+b);
        }
        static void Main(string[] args)
        {
            X<string> g = new X<string>("hello");
            X<int> g1 = new X<int>(3);
            X<char> g2 = new X<char>('A');
            int x1 = 27;
            int x2 = 31;
            Console.WriteLine("BEFORE SWAP :  a: " + x1 + "  b: " + x2);
            swap<int>(ref x1, ref x2);
            Console.ReadLine();
        }
    }
}
