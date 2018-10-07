using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice2
{
	class Program
	{
		static void Main(string[] args)
		{
			int plusTwelve = MathClass.AddUserNumber(12);
			Console.WriteLine(plusTwelve);
			Console.ReadLine();
			int secondMethod = MathClass.AddUserNumber(1.5m);
			Console.WriteLine(secondMethod);
			Console.ReadLine();
			//string thirdMethod = MathClass.AddUserNumber("3");
			//Console.WriteLine(thirdMethod);
			//Console.ReadLine();


		}
	}
}
