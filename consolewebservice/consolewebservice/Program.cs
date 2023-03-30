using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolewebservice
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.WebServiceSoapClient x = new ServiceReference1.WebServiceSoapClient();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ADD:" + x.addition(a, b));
            Console.WriteLine("SUB:" + x.subtraction(a, b));
            Console.WriteLine("MUL:" + x.multiplication(a, b));
            Console.WriteLine("DIV:" + x.division(a, b));
            Console.ReadLine();
        }
    }
}
