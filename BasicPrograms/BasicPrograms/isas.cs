//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class class1 { }
//    class class2 { }
//    class isasdemo
//    {
//        static void Main(string[] args)
//        {
//            class1 x = new class1();
//            class2 y = new class2();
//            testing(x);
//            testing(y);
//            Console.ReadLine();

//        }

//        static void testing(object obj)
//        {
//            class1 c1;
//            class2 c2;
            
//            if (obj is class1)
//            {
//                Console.WriteLine("obj is class1");
//                c1 = (class1)obj;
//            }
//            else if(obj is class2)
//            {
//                Console.WriteLine("OBJ IS CLASS2");
//                c2 = (class2)obj;
//            }
//            else
//            {
//                Console.WriteLine("neither class 1 or 2");
//            }

//        }
//    }
//}
