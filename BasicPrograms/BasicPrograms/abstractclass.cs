//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{ 
//    public abstract class A
//    {
//        public abstract void fun1();
//        public abstract void fun2();
//        public void fun3()
//        {
//            Console.WriteLine("this is fun3 in abstract class");
//        }

//    }
//    class B : A
//    {
//        public override void fun1()
//        {
//            Console.WriteLine("THIS IS FUN1");
//        }

//        public override void fun2()
//        {
//            Console.WriteLine("This is fun2");
//        }
//    }
//    class abstractclass
//    {
//        static void Main(string[] args)
//        {
//            B b = new B();
//            b.fun1();
//            b.fun2();
//            b.fun3();
//            Console.ReadLine();
//        }
//    }
//}
