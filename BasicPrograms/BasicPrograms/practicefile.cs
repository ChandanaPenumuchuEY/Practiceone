//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class practicefile
//    {
//        static void Main(string[] args)
//        {
//            string data;
//            if (!File.Exists(@"C:\Users\labuser\Desktop\simplelearn\banglore\whitefield\first.txt"))
//            {
//                Directory.CreateDirectory(@"C:\Users\labuser\Desktop\simplelearn\banglore\whitefield");
//                var v1 = File.Create(@"C:\Users\labuser\Desktop\simplelearn\banglore\whitefield\first.txt");
//                v1.Close();
//            }
//            if (!File.Exists(@"C:\Users\labuser\Desktop\simplelearn\banglore\skillboard\second.txt"))
//            {
//                Directory.CreateDirectory(@"C:\Users\labuser\Desktop\simplelearn\banglore\skillboard");
//                var v2 = File.Create(@"C:\Users\labuser\Desktop\simplelearn\banglore\skillboard\second.txt");
//                v2.Close();
//            }
//            if (!File.Exists(@"C:\Users\labuser\Desktop\simplelearn\delhi\ncr\file3.txt"))
//            {
//                Directory.CreateDirectory(@"C:\Users\labuser\Desktop\simplelearn\delhi\ncr");
//                var v3 = File.Create(@"C:\Users\labuser\Desktop\simplelearn\delhi\ncr\file3.txt");
//                v3.Close();
//            }
//            Console.WriteLine("enter data to file 1");
//            data = Console.ReadLine();
            
//           File.AppendAllText(@"C:\Users\labuser\Desktop\simplelearn\banglore\whitefield\first.txt",data);
//            Console.WriteLine("DATA INPUTED TO FILE 1");
//            Console.WriteLine("enter data to file 2");
//            data = Console.ReadLine();
//            File.AppendAllText(@"C:\Users\labuser\Desktop\simplelearn\banglore\skillboard\second.txt", data);
//            Console.WriteLine("DATA INPUTED TO FILE 2");
//            Console.WriteLine("enter data to file 3");
//            data = Console.ReadLine();
//            File.AppendAllText(@"C:\Users\labuser\Desktop\simplelearn\delhi\ncr\file3.txt", data);
//            Console.WriteLine("DATA INPUTED TO FILE 3");
//            Console.WriteLine("data in file1");
//            Console.WriteLine(File.ReadAllText(@"C:\Users\labuser\Desktop\simplelearn\banglore\whitefield\first.txt"));

//            Console.WriteLine("data in file2");
//            Console.WriteLine(File.ReadAllText(@"C:\Users\labuser\Desktop\simplelearn\banglore\skillboard\second.txt"));


//            Console.WriteLine("data in file3");
//            Console.WriteLine(File.ReadAllText(@"C:\Users\labuser\Desktop\simplelearn\delhi\ncr\file3.txt"));

//            Console.ReadLine();
         
//        }
//    }
//}
