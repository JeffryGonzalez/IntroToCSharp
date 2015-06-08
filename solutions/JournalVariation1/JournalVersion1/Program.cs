using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalVersion1
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileName = ConfigurationManager.AppSettings.Get("fileName");
			Console.Write("Enter Your Journal Entry: ");
			var entry = Console.ReadLine();
			if (entry.Length > 140)
			{
				entry = entry.Substring(0, 140);
				Console.WriteLine("Your entry is too big. I'm truncating it to {0}", entry);
			}
			StreamWriter textWriter = null;
			if (!File.Exists(fileName))
			{
				textWriter = File.CreateText(fileName);
			}
			else
			{
				textWriter = new StreamWriter(File.Open(fileName, FileMode.Append));
			}

			
			textWriter.WriteLine("{0:d}", DateTime.Now);
			textWriter.WriteLine("{0:t}", DateTime.Now);
			textWriter.WriteLine(entry);
			textWriter.WriteLine();
			textWriter.WriteLine();
			textWriter.Close();
			Console.WriteLine("Entry Added. Good day.");
		}
	}
}
