using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolution1
{
	class Program
	{
		static void Main(string[] args)
		{
			var toBeWritten = "";
			foreach (var number in Enumerable.Range(1, 100))
			{
				if (number%3 == 0 && number%5 == 0)
				{
					toBeWritten = "FizzBuzz";
				}
				else if (number%3 == 0)
				{
					toBeWritten = "Fizz";
				}
				else if (number%5 == 0)
				{
					toBeWritten = "Buzz";
				}
				else
				{
					toBeWritten = number.ToString();
				}
				Console.Write(toBeWritten);
			}
		}
	}
}
