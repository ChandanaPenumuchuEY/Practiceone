//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class calci
//    {
//        static void Main(string[] args)
//        {
//            string ch = "yes";
//            while((ch=="yes" || ch== "Y"|| ch=="YES" || ch=="y")&&(ch!="no" || ch!="NO" || ch!="n"|| ch!="N"))
//            {
//                Console.WriteLine("ENTER FIRST NUMBER   : ");
//                int a = int.Parse(Console.ReadLine());
//                Console.WriteLine("ENTER FIRST NUMBER   : ");
//                int b = int.Parse(Console.ReadLine());
//                Console.WriteLine("ENTER OPERATOR   : ");
//                char op = Convert.ToChar(Console.ReadLine());
//                float res;
//                switch (op)
//                {
//                    case '+':
//                        res = a + b; ;
//                        Console.WriteLine("RESULT"+res);
//                        break;
//                    case '-':
//                        res = a - b; ;
//                        Console.WriteLine("RESULT"+res);
//                        break;
//                    case '*':
//                        res = a * b; ;
//                        Console.WriteLine("RESULT"+res);
//                        break;
//                    case '/':
//                        res = a /b; ;
//                        Console.WriteLine("RESULT"+res);
//                        break;
//                    case '%':
//                        res = a % b; ;
//                        Console.WriteLine("RESULT"+res);
//                        break;
//                   default:
//                        Console.WriteLine("enter correct operator");
//                        break;


//                }

//                Console.WriteLine("Do you want to continue");
//                ch = Console.ReadLine();

//            }
//            Console.ReadLine();
//        }
//    }
//}
