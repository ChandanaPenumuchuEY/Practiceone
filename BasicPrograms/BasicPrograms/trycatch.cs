//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class trycatch
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                int a, b;
//                a = int.Parse(Console.ReadLine());
//                b = int.Parse(Console.ReadLine());
//                int x = a / b;
//                string ar = null;
//                ar.ToString();
//            }
//            catch (NullReferenceException e)
//            {
//                Console.WriteLine(e.Message);

//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}
