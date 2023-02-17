using System;
using System.IO;

namespace BasicPrograms
{
	class namespacwclass
	{

        static void Main(string[] args)
        {
          String  path = " C:\\Users\\labuser\\Desktop\\Student.txt";
      
            if(File.Exists(path))
              {
                Console.WriteLine("Student details are :");

                string[] lines = File.ReadAllLines(path);

                foreach (var l in lines)
                {
                    Console.WriteLine(l);
                }
            }
        else
                Console.WriteLine(" Student File does not exist");
		Console.ReadLine();
        }
	}
}





/*
using System;
using System.IO;

namespace BasicPrograms
{
	class namespaceclass
	{
        static void Main(string[] args)
        {
        FileInfo f = new FileInfo("C:\\Users\\labuser\\Desktop\\happy.txt.txt");
        Console.WriteLine(f.Name);
			Console.WriteLine(f.LastAccessTime);
			Console.WriteLine(f.Length);
       if(File.Exists("C:\\Users\\labuser\\Desktop\\happy.txt.txt"))
        {
            Console.WriteLine("File is present");

            string[] lines = File.ReadAllLines(@"C:\Users\labuser\Desktop\happy.txt.txt");

            foreach (var l in lines)
            {
                Console.WriteLine(l);
            }
        }
        else
            { 
            Console.WriteLine("File does not exist");
				}

		Console.ReadLine();
    }
}
}*/


/*namespace X
{
	class c1
	{
		public void method1()
			{
		        Console.WriteLine("I am calling  method 1 of c1 in namespace X");
			}
	}
}

namespace Y
{
	class c2
	{
		public void method2()
		{
			Console.WriteLine("I am calling method 2 of c2 in namespace Y");
		}
	}
}
namespace Z
{
	class c3
	{
		public void method3()
		{
			Console.WriteLine("I am calling method 3 of c3 in namespace Z");
		}
	}
}

namespace BasicPrograms
{
	class namespaaceclass
	{
		static void Main(string[] args)
		{
			X.c1 obj1 = new X.c1();
			obj1.method1();
			Y.c2 obj2 = new Y.c2();
			obj2.method2();
			Z.c3 obj3 = new Z.c3();
			obj3.method3();
			Console.ReadLine();
		}
	}
}*/
