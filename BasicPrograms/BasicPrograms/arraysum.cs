using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class arraysum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter no .of rows");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter no .of columns");
            int c1 = int.Parse(Console.ReadLine());
            int[,] a = new int[r1, c1];
            int[,] b = new int[r1, c1];
            int[,] c = new int[r1, c1];
            int i, j,k;
            Console.WriteLine("ENTER ELEMENTS OF FRST ARRAY");
            for(i=0;i<r1;i++)
            {
                for(j=0;j<c1;j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("ENTER ELEMENTS OF SECOND ARRAY");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                    c[i, j] = 0;
                }
            }
            Console.WriteLine("SUM OF TWO ARRAYS");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write(a[i, j] + b[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("PRODUCT OF TWO ARRAYS");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    for(k=0;k<c1;k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                   // Console.Write(c[i, j]+" ");
                }
               
            }
            for(i=0;i<r1;i++)
            {
                for(j=0;j<c1;j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        } 
    }
}
