//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class filehandlingg
//    {
//        static void Main(string[] args)
//        {
//            FileInfo f = new FileInfo(@"C:\Users\labuser\Desktop\Student.txt");
//            Console.WriteLine("FILE NAME"+f.Name);
//            Console.WriteLine("FILE FULL NAME"+f.FullName);
//            Console.WriteLine("FILE LAST ACCESS TIME"+f.LastAccessTime);
//            Console.WriteLine("FILE LENGTH"+f.Length);
//            Console.WriteLine("FILE DIRECTORY NAME"+f.DirectoryName);
//            Console.WriteLine("FILE CREATION TIME"+f.CreationTime);
//            Console.WriteLine("**********************************DRIVE INFO*********************************");
//            DriveInfo d = new DriveInfo("C:\\");
//            Console.WriteLine("DRIVE NAME"+d.Name);
//            Console.WriteLine("DRIVE VOLUME LABEL"+d.VolumeLabel);
//            Console.WriteLine("DRIVE AVAILABLE FREE SPACE"+d.AvailableFreeSpace);
//            Console.WriteLine("DRIVE TOTAL FREE SPACE"+d.TotalFreeSpace);
//            Console.WriteLine("DRIVE TYPE"+d.DriveType);
//            Console.WriteLine("DRIVE ROOT DIRECTORY"+d.RootDirectory);
//            Console.WriteLine("DRIVE TOTAL SIZE"+d.TotalSize);

//            Console.WriteLine("**********************************CREATINGGGGG DIRECTORYYYY*********************************");
//            string dct = @"C:\Users\labuser\Desktop\demo2";
//            Directory.CreateDirectory(dct);
//            Directory.CreateDirectory(@"C:\Users\labuser\Desktop\demo1");
//            Directory.CreateDirectory(@"C:\Users\labuser\Desktop\demo3");
//            Directory.Delete(@"C:\Users\labuser\Desktop\demo3");
//            foreach (var dname in Directory.GetFiles(@"C:\Users\labuser\Desktop"))
//            {
//                Console.WriteLine(dname);

//            }



//            Console.WriteLine("**********************************STREAMMMMMMMMM WRITERRRRRRRRRRRRRRRR*****************");
//            StreamWriter w = new StreamWriter(@"C:\Users\labuser\Desktop\Student.txt");
//             string sl=Console.ReadLine();
//                w.WriteLine(sl);
//                w.Close();
            

//            Console.WriteLine("****************FIIIIIIILEEEEEEEEEEEEEE*********************************");
//            File.AppendAllText(@"C:\Users\labuser\Desktop\Student.txt","dsvfdbdfbbgbdfbdfbdf");


//            Console.WriteLine("**********************************STREAMMMMMMMMM READERRRRRRRRRRRRRRRR*********************************");
//            StreamReader a = new StreamReader(@"C:\Users\labuser\Desktop\Student.txt");
//            string x;
//            // Console.WriteLine(a.Read().ToString());
//            while ((x = a.ReadLine()) != null)
//            {
//                Console.WriteLine(x + "  the end");
//            }



//            Console.ReadLine();










//        }
//    }
//}
