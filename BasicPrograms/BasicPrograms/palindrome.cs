//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class palindrome
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int n1 = n;
//            int rev = 0;
//            while (n1 > 0)
//            {
//                int l = n1 % 10;
//                rev = rev * 10 + l;
//                n1 = n1 / 10;
//            }
//            if (rev == n)
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("not palindrome");
//            }
//            Console.ReadLine();
//        }
//    }
//}
