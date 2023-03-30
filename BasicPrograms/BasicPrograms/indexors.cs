using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   
    class indexors
    {
    private string[] namelist = new string[size];
    static public int size = 10;

    public indexors()
    {
        for (int i = 0; i < size; i++)
        {
            namelist[i] = "empty";
        }
    }
    public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index < size - 1)
                {
                    namelist[index] = value;
                }

            }
        }
    

    static void Main(string[] args)
    {
        indexors names = new indexors();
        names[0] = "a";
        names[1] = "a";
        names[2] = "a";
        names[3] = "trtya";
        names[4] = "atyt";
        names[5] = "atyr";
        names[6] = "atry";
        names[7] = "a";
        for(int i=0;i<indexors.size;i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();
    }
}
}
