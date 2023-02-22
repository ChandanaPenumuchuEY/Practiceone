// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Queue q= new Queue(5);
        q.Enqueue("hi");
        q.Enqueue("chandu");
        q.Enqueue(50);
        q.Dequeue();
        q.Enqueue(8.97);
       Console.WriteLine(q.Peek());
        foreach(var x in q)
        {
            Console.WriteLine(x+"  ");
        }
        q.Clear();
        foreach(var x in q)
        {
            Console.WriteLine(x+"  ");
        }
        
    }
}
