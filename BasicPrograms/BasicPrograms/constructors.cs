using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{

    class bike
    {
       public bike()
        {
            Console.WriteLine("I am royal enfield");
        }
        public bike(int cc)//parameterized constructor
        {
            Console.WriteLine("I am royal enfield "+cc);
        }
    }
    class constructors
    {
        static void Main(string[] args)
        {
            bike b = new bike();
            bike b1 = new bike(650);
            
            Console.ReadLine();

        }
    }
}
