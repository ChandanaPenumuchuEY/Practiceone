//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class genericpredefinedfunctions
//    {
//        static void Main(string[] args)
//        {
//            Stack<int> s = new Stack<int>();
//            s.Push(1);
//            s.Push(2);
//            s.Push(21);
//            s.Pop();
//            Console.WriteLine("Stack Valuess");
//            foreach (var i in s)
//              {
//                Console.WriteLine(i);
//            }
//            Queue<int> q = new Queue<int>();
//            q.Enqueue(1);
//            q.Enqueue(2);
//            Console.WriteLine("Queue Valuess");
//            foreach (var i in q)
//            {
//                Console.WriteLine(i);
//            }
//            LinkedList<int> l = new LinkedList<int>();
//            l.AddFirst(9);
//            l.AddLast(8);
//            var x=l.AddLast(7);
//            l.AddLast(6);
//           var y= l.AddLast(5);
//            l.AddBefore(x, 10);
//            l.AddAfter(y, 11);
//            Console.WriteLine("Linked List Valuess");
//            foreach (var i in l)
//            {
//                Console.WriteLine(i);
//            }
//            Console.ReadLine();

//        }
//    }
//}
