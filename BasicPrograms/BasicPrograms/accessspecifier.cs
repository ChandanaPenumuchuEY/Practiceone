//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class cse
//    {
//        private int id;
//        int course;
//    }
//    class ece
//    {
//        protected int id;
//        protected int course;
//    }
//    class it
//    {
//        public int id;
//        protected int course;
//        static int x = 7;
//        public void check()
//        {
//            Console.WriteLine(id);

//        }
//        public static void smethod()
//        {
//            Console.WriteLine(x);
//        }

//    }
//    class accessspecifier
//    {
//        static void Main(string[] args)
//        {
//            cse c = new cse();
//            //cannot access private protected and no access specifier
//            //by default all access specifiers are private
//            ece e = new ece();
//            it ii = new it();
//            ii.id = 6;
//            it i = new it();
//            ii.check();
//            it.smethod();
//            i.check();
//            Console.ReadLine();
//        }
//    }
//}
