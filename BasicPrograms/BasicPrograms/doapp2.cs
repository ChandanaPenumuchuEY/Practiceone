using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class doapp2
    {
        static void Main(string[] args)
        {
            doApp();
        }
         static public void doApp()
        {
            int i = 10;
            if (i == 10)
            {
                Console.WriteLine(" THIS IS IN IF CONDITION");
            }
            switch (i)
            {
                case 10:
                    Console.WriteLine("THIS IS SWITCH case 10 CONDITION");
                    break;
                case 9:
                    Console.WriteLine("THIS IS SWITCH case 9 CONDITION");
                    break;
                default:
                    Console.WriteLine("THIS IS SWITCH default CONDITION");
                    break;

            }
            Console.WriteLine("THIS IS FOR LOOP ITERATION");
            for (i = 10; i <= 30; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("THIS IS WHILE LOOP");
            while (i >= 20)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("THIS IS DO WHILE LOOP");
            do
            {
                Console.WriteLine(i);
                i--;

            } while (i >= 1);
            String[] x = { "one", "two", "three" };
            foreach(String s  in x)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }
    }
}
