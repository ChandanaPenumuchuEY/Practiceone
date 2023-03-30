//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{

//    class College:department
//    {
//        public void cname()
//        {
//            Console.WriteLine("this is vignan university");
//        }

//    }
//    class faculty
//        {
//        protected int fid = 5;
//        private int prfid = 5;
//        int f = 8;
//        public void fname()
//        {
//            Console.WriteLine("this is subbarao");
//        }

//    }
//    class student:department
//    {
//        private int sid = 5;
//        public void sname()
//        {
//            Console.WriteLine("this is chandana");

//        }
//    }
//    class oopssconcepts1
//    {
//        static void Main(string[] args)
//        {
//            College c1 = new College();
//            c1.cname();
//            // department d = new department();
//            c1.dname();
//            c1.fname();
         
//            student s = new student();
//            s.sname();
//            s.dname();
//            //protected mem can be accesses to immediate class
//            s.fname();
//            s.dname();
//            Console.ReadLine();
//        }
//    }
//}
