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

			ShowEntries(fileName);

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

		public static void ShowEntries(string fileName)
		{
			if (File.Exists(fileName))
			{
				var entries = new List<Entry>();
				// read each entry in.
				var reader = File.OpenText(fileName);
				while (reader.Peek() >= 0)
				{
					// assume date, time, entry, line line
					var dateOfEntry = reader.ReadLine();
					var timeOfEntry = reader.ReadLine();
					var theEntry = reader.ReadLine();
					reader.ReadLine();
					reader.ReadLine();
					entries.Add(new Entry(dateOfEntry, timeOfEntry, theEntry));

				}
				reader.Close();
				var allEntries = entries.OrderBy(e => e.EntryDate);
				IEnumerable<Entry> lastEntries = null;
				var numberOfEntries = allEntries.Count();
				lastEntries = numberOfEntries > 5 ? allEntries.Skip(numberOfEntries - 5).Take(5) : allEntries;
				
				Console.BackgroundColor = ConsoleColor.White;
				Console.Clear();

				foreach (var entry in lastEntries)
				{
					Console.ForegroundColor = ConsoleColor.DarkBlue;
					Console.WriteLine(entry.EntryDate.ToLongDateString());
					Console.WriteLine(entry.EntryTime);
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine(entry.EntryText);

					Console.WriteLine();
				} 
			}
		}
	}
}
