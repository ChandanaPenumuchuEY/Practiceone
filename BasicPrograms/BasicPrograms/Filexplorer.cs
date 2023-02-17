using System;
using System.IO;

namespace Filexplorer
{
	public Class1
	{
        static void Main(string[] args)
        {
        FileInfo f = new FileInfo(@"Descktop\happy.txt");
        Console.WriteLine(f.name);
        f(File.Exists(path))
        {
            Console.WriteLine("File is present");

            string[] lines = File.ReadAllLines(path);

            foreach (var l in lines)
            {
                Console.WriteLine(l);
            }
        }
        else
            Console.WriteLine("File does not exist");

    }
}
}
