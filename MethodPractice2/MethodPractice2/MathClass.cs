using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice2
{
	public class MathClass
	{
		public static int AddUserNumber(int i)
		{
			return i + 10;
		}

		public static int AddUserNumber(decimal j)
		{
			decimal k = j * 5;
			int f = Convert.ToInt32(k);
			return f;
		}

		//I cannot get the method to take a string to an int.  I keep getting an error. 
		//public static int AddUserNumber(string h )
		//{
		//	var g;
		//	if (Int32.TryParse(h, out g))
		//		//int b = g * 20;
		//		return g;
		//	else
		//		Console.WriteLine("Could not convert to integer.");
		}

	}
}
