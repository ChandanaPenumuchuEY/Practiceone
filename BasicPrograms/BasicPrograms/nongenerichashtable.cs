//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace BasicPrograms
//{
//    class nongenerichashtable
//    {
//        static void Main(string[] args)
//        {
//            Hashtable h = new Hashtable(5);
//            h.Add(1, "chandu");
//            h.Add(27, "mint");
//            h.Add(31, "honey");
//            h.Add(4, "ishi");
//            h.Remove(27);
//            foreach(DictionaryEntry x in h)
//            {
//                Console.WriteLine("KEY : " + x.Key + "  VALUE :" + x.Value);
//            }
//            Console.WriteLine(h.ContainsValue("chandu"));
//            Console.WriteLine(h.ContainsKey(21));
//            Console.WriteLine(h.IsFixedSize);
//            Console.ReadLine();
//        }
//    }
//}
