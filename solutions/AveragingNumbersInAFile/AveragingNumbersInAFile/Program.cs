using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveragingNumbersInAFile
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"c:\practices\numbers.txt";
			var numbers = new List<double>();

			if (File.Exists(fileName))
			{
				var f = File.OpenText(fileName);
				while (f.Peek() >= 0)
				{
					numbers.Add(double.Parse(f.ReadLine()));
				}

				Console.WriteLine("The average of all the number is {0}", numbers.Average());
			}
			else
			{
				Console.WriteLine(@"The File c:\practices\numbers.txt does not exit");
			}
		}
	}
}
