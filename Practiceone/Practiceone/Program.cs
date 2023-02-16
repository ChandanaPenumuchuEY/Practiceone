///* BASIC PROGRAM */
//using System;
//namespace Practiceone
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int p = 27;
//			float c = 31.01f;
//			char h = 's';
//			String name = "Chandu";
//			Console.Write(p);// print same line
//			Console.Write(name);
//			Console.WriteLine(h);// print new line
//			Console.WriteLine(c);

//			//Console.Read();// enter
//			//Console.ReadLine();
//			Console.ReadKey();//key
//		}

//	}

//}
//----------------------------------------------------------------------------


///* DISPLAY NAME AND ROLL NUM */
//using System;
//namespace Practiceone
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int rn = int.Parse(Console.ReadLine());
//			String name = Console.ReadLine();
//			Console.WriteLine("ROLL NUMBER :  "+rn);
//			Console.Write("NAME     : " + name);
//			Console.Read();// enter


//		}

//	}

//}

//---------------------------------------------

///* CALCULATION */
//using System;
//namespace Practiceone
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int a = int.Parse(Console.ReadLine());
//			int b = int.Parse(Console.ReadLine());
//			Console.WriteLine("ADDITION OF TWO NUMBERS :  " + (a + b));
//			Console.WriteLine("SUBTRACTION OF TWO NUMBERS :  " + (a - b));
//			Console.WriteLine("PRODUCT  OF TWO NUMBERS :  " + (a * b));
//			Console.WriteLine("DIVISION OF TWO NUMBERS :  " + (a / b));

//			Console.Read();// enter


//		}

//	}

//}

///* SIMPLE INTREST */
//using System;
//namespace Practiceone
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int a = int.Parse(Console.ReadLine());
//		    float i = float.Parse(Console.ReadLine());
//			int t = int.Parse(Console.ReadLine());
//			float si= (float)(a * i * t)/100;
//			Console.WriteLine("SIMPLE INTREST :" +si);

//			Console.ReadLine();// enter

//		}

//	}

//}

//---------------------------------------------------------
/* CIRCUMFERENCE OF CIRCLE */
//using System;
//namespace Practiceone
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			const float pi = 3.14f;
//			Console.Write("Enter radius of the circle");
//			int r = int.Parse(Console.ReadLine());
//			double cir = 2 * pi * r;
//			Console.WriteLine("CIRCUMFERENCE :  " + cir);
//			Console.Read();// enter


//		}

//	}

//}

//-------------------------------------------------------------------
//using System;
//namespace Practiceone
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			byte[] x = { 1, 2, 3, 4, 5 };
//			Console.WriteLine(" converting to string using base convertor " + BitConverter.ToString(x));
//			String s = Convert.ToBase64String(x);
//			Console.WriteLine(s);
//			Console.ReadLine();


//		}

//	}

//}