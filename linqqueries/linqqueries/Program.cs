using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace linqqueries
{

    class Student
    {
        public int sid { get; set; }
        public string name { get; set; }
        public string dep { get; set; }
    }
    class Teacher
    {
        public int tid { get; set; }
        public string name { get; set; }
        
        public string dep { get; set; }
    }
   

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("LOOK UP");
            List<Student> stu = new List<Student>() { 
            new Student() { sid = 1, name = "chandu", dep = "cse" },
            new Student() { sid = 2, name = "mintu", dep = "ece" },
            new Student() { sid = 3, name = "ravi", dep = "cse" },
            new Student() { sid = 4, name = "teja", dep = "it" },
            new Student() { sid = 5, name = "shashi", dep = "it" },
            new Student() { sid = 6, name = "varun", dep = "ece" },
            new Student() { sid = 7, name = "ishi", dep = "eee" },
            new Student() { sid = 8, name = "pooji", dep = "eee" },
            new Student() { sid = 9, name = "pranathi", dep = "cse" },
            new Student() { sid = 10, name = "ramboo", dep = "it" }
            };

            var dept = stu.ToLookup(x => x.dep);
          //  Console.WriteLine(string.Join("_",dept));

            foreach (var q in dept)
            {
                Console.WriteLine("DEPARTMENT :   "+q.Key);
                foreach(var z in stu)
                {
                    if(z.dep==q.Key)
                    {
                        Console.WriteLine("ID : " + z.sid + " NAME : " + z.name);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************************");
            Console.WriteLine("DICTIONARYYYYYYYYY");
            var dic = stu.ToDictionary(x => x.sid, x => x.name);
            foreach (var k in dic)
            {
                
                    Console.WriteLine("ID : " + k.Key + " NAME : " +k.Value);
                
            }

            Console.WriteLine("*********************************************************");
            Console.WriteLine(" CAST");
            ArrayList x = new ArrayList();
         //  x.Add(5);
            x.Add("hi");
        //   x.Add(87);
            x.Add("chandu");
            x.Add("holaaaaaaa");
            x.Add("luckyyyyy");
            x.Add("Guntur");
            x.Add("one");
            x.Add("two");
            IEnumerable<string> r = x.Cast<string>();
            foreach(var e in r)
            {
                Console.WriteLine(e);
            }
               Console.WriteLine("*********************************************************");

            IList<string> str = new List<string>() {"6","oneeeeeeeeeee" ,"two","chandu","three","guntur","toy"};
            //take,takewhile,skip,skipwhile
            Console.WriteLine("*********************************************************");
            Console.WriteLine(" TAKE WHILE");
            var res = str.TakeWhile(s => s.Length <= 3);
            Console.WriteLine(string.Join("_", res));
            Console.WriteLine(" SKIP WHILE");
            var res1 = str.SkipWhile(s => s.Length <= 4);
            Console.WriteLine(string.Join("_", res1));
            Console.WriteLine(" TAKE");
            var res2 = str.Take(4);
            Console.WriteLine(string.Join("_", res2));
            Console.WriteLine(" SKIP");
            var res3 = str.Skip(4);
            Console.WriteLine(string.Join("_", res3));


            //FILTERS
            Console.WriteLine("*********************************************************");

            
            var intv = from i in x.OfType<int>()
                       select i;

            Console.WriteLine(string.Join("_", intv));
            var stringv = from i in x.OfType<string>()
                       select i;

            Console.WriteLine(string.Join("_", stringv));




            Console.WriteLine("*********************************************************");


            //linq queries with lamba expressions
            int[] arr = { 4, 76, 87, 5, 76, 0, 6, 43, 5, 54, 65, 7, 1, 3, 33 };
            var xy = arr.Where(n => n >= 45);
            foreach(var i in xy)
            {
                Console.WriteLine(i);
            }
            //with 2 variables
            Console.WriteLine("lambda expression using 2 variables");
            var y = arr.Where((n, i) => n > 2 && i < arr.Length);
            foreach (var i in y)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("METHOD QUERIES");
            //method syntax
            Console.WriteLine(arr.Last());
            Console.WriteLine(arr.First());
            Console.WriteLine(arr.First(arr => arr.Equals(7))) ;
            Console.WriteLine(arr.First());
            //join
            Console.WriteLine(string.Join('@',arr));
            var v1 = arr.Prepend(100);
            var v2 = v1.Append(200);
            Console.WriteLine(string.Join('@', v2));
            //math inbuilt functiond
            int[] a= { 1, 2, 3 };
            var v = a.Select(x => Math.Pow(x, 3));
            Console.WriteLine(string.Join('_',v));
             v = a.Select(x => Math.Log10(x));
            Console.WriteLine(string.Join('_', v));
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("As enumerabel");
            int[] qw = { 1, 2, 3, 4, 5 };
            var wq = qw.AsEnumerable();
            foreach(var i in wq)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("As queyable");
            Console.WriteLine(qw.Average());
            Test(qw.AsQueryable());

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("DEFAULT IF EMPTY");

            List<Teacher> tch = new List<Teacher>() {
            new Teacher() { tid = 1, name = "tchandu", dep = "cse" },
            new Teacher() { tid = 21, name = "tmintu", dep = "ece" },
            new Teacher() { tid = 3, name = "travi", dep = "cse" },
            new Teacher() { tid = 41, name = "tteja", dep = "it" },
            new Teacher() { tid = 5, name = "tshashi", dep = "it" },
            new Teacher() { tid = 61, name = "ttvarun", dep = "ece" },
            new Teacher() { tid = 7, name = "tishi", dep = "eee" },
            new Teacher() { tid = 81, name = "ptooji", dep = "eee" },
            new Teacher(){ tid = 9, name = "tpranathi", dep = "cse" },
            new Teacher() { tid = 11, name = "tramboo", dep = "it" }
            };
            Console.WriteLine("JOIN USING QUERIES");
            var resst = from s in stu
                        join
          t in tch on s.sid equals t.tid
          
          //into ress
                       // from output in ress.DefaultIfEmpty()
                        select new
                        {
                            rid=s.sid,
                            rname=s.name,
                            rdep=t.dep
                        };

            Console.WriteLine(string.Join("\n" ,resst.Select(ex => ex.rid))+"  NAME: "+string.Join("\n", resst.Select(ex => ex.rname)));


            Console.WriteLine("INNER JOIN USING LAMBA EXPRESSION");
            var lj = stu.Join(tch, e1 => e1.sid, e2 => e2.tid,
                (e1, e2) => new
                {
                    lid=e1.sid,
                    ltname=e2.name
                });
            foreach(var i in lj)
                {
                Console.WriteLine("id: " + i.lid + "  name : " + i.ltname);
            }

            Console.WriteLine("LEFT JOIN USING QUERY");
            var leftjoinn = from s in stu  join
          t in tch on s.sid equals t.tid
                        into newtab
                         from output in newtab.DefaultIfEmpty()
                        select new
                        {
                            rid = s.sid,
                            rname = s.name,
                            rdep=output==null?"no dep":output.dep
                          
                        };
            foreach (var i in leftjoinn)
            {
                Console.WriteLine("id: " + i.rid + "  name : " + i.rname+"   dep : "+i.rdep);
            }
            Console.WriteLine("CROSS JOIN USING QUERY");

            var crossjoinn = from s in stu
                             from t in tch
                             select new
                             {
                                 sid = s.sid,
                                 tid = t.tid
                             };

            foreach (var i in crossjoinn)
            {
                Console.WriteLine("SID : "+i.sid+"  TID : "+i.tid);
            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine(" SET OPERATORSS");
            string[] x1 = { "a", "b", "c", "d", "e" };
            string[] x2 = { "f", "g", "h", "d", "e" };
            var unionn = x1.Union(x2);
            var intersectt = x1.Intersect(x2);
          //  var distinctt = x1.Distinct(x2);
            var exceptt = x1.Except(x2);
            Console.WriteLine("UNION");
            foreach (var i in unionn)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("INTERSECT");
            foreach (var i in intersectt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("EXCEPT");
            foreach (var i in exceptt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************************************************************");
            Console.ReadLine();
        }

        static void Test(IQueryable<int> items)

        {
            Console.WriteLine("Average"+items.Average());
            Console.WriteLine("Sum :" + items.Sum());

        }
    
    }

}
