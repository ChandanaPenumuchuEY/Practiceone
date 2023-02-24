using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class filehandlingg
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(@"C:\Users\labuser\Desktop\Student.txt");
            Console.WriteLine("FILE NAME"+f.Name);
            Console.WriteLine("FILE FULL NAME"+f.FullName);
            Console.WriteLine("FILE LAST ACCESS TIME"+f.LastAccessTime);
            Console.WriteLine("FILE LENGTH"+f.Length);
            Console.WriteLine("FILE DIRECTORY NAME"+f.DirectoryName);
            Console.WriteLine("FILE CREATION TIME"+f.CreationTime);
            Console.WriteLine("**********************************DRIVE INFO*********************************");
            DriveInfo d = new DriveInfo("C:\\");
            Console.WriteLine("DRIVE NAME"+d.Name);
            Console.WriteLine("DRIVE VOLUME LABEL"+d.VolumeLabel);
            Console.WriteLine("DRIVE AVAILABLE FREE SPACE"+d.AvailableFreeSpace);
            Console.WriteLine("DRIVE TOTAL FREE SPACE"+d.TotalFreeSpace);
            Console.WriteLine("DRIVE TYPE"+d.DriveType);
            Console.WriteLine("DRIVE ROOT DIRECTORY"+d.RootDirectory);
            Console.WriteLine("DRIVE TOTAL SIZE"+d.TotalSize);

            Console.ReadLine();










        }
    }
}
