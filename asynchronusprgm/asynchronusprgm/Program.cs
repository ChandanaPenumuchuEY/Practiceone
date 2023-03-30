﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynchronusprgm
{
    class Program
    {
        static void Main(string[] args)
        {
           callMethod();
            Console.ReadLine();
        }

        public static async void callMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);

        }
         
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for(int i=0;i<100;i++)
                {
                    Console.WriteLine(i + "Method 1");
                    count++;
                }
             

            });
            return count;

        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(i + "Method 2");
            }

        }

        public static void Method3(int count)
        {
            Console.WriteLine("count = " + count);
        }
    }
}