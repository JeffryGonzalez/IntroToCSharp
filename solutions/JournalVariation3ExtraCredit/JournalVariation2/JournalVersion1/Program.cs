using JournalDomain;
using System;

namespace JournalVersion1
{
	class Program
	{
		private static readonly JournalWriter _journalWriter = new JournalWriter();

		static void Main(string[] args)
		{

			ShowEntries();
			Console.Write("Enter Your Journal Entry: ");
			var entryText = Console.ReadLine();
			_journalWriter.AddEntry(Entry.Create(entryText));

			Console.WriteLine("Entry Added. Good day.");
		}

		public static void ShowEntries()
		{
			var lastEntries = _journalWriter.GetLastEntries();
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

