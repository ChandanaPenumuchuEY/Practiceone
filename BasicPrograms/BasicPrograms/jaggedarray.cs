// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [][] a = new int[2][];
        a[0]=new int[]{1,2,3,4};
        a[1]=new int[]{1,2};
        for(int i=0;i<a.Length;i++)
        {
            for(int j=0;j<a[i].Length;j++)
            {
                Console.WriteLine(a[i][j]+" ");
            }
        }
    }
}
