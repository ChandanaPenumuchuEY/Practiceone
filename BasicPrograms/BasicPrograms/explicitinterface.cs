//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    interface Ia
//    {
//        void add();
//    }
//    interface Ib
//    {
//        void diff();
//    }
//    class X : Ia, Ib
//    {
//        void Ia.add()
//        {
//            Console.WriteLine("this is add function");
//        }

//        void Ib.diff()
//        {
//            Console.WriteLine("this is diff function");
//        }
//    }
//    //sealed classes cannot be inherited
//    sealed class Y
//    {
//        public void yadd()
//        {
//            Console.WriteLine("THIS IS SEALED CLASS AND CANNOT BE INHERITED");
//        }
//    }
//    class explicitinterface
//    {
//        static void Main(string[] args)
//        {
//            Ia w = new X();
//            w.add();
//            Ib q = new X();
//            q.diff();
//            Y y = new Y();
//            y.yadd();
//            Console.ReadLine();
//        }
//    }
//}
