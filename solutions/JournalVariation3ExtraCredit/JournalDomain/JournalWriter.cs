using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDomain
{

	public class JournalWriter
	{

		private readonly string _fileName;

		public JournalWriter()
		{
			_fileName = ConfigurationManager.AppSettings.Get("fileName");
			if (!File.Exists(_fileName))
			{
				File.CreateText(_fileName).Close();
			}
		}

		public void AddEntry(Entry entry)
		{

			var textWriter = new StreamWriter(File.Open(_fileName, FileMode.Append));

			textWriter.WriteLine("{0:d}", entry.EntryDate);
			textWriter.WriteLine("{0:t}", entry.EntryDate);
			textWriter.WriteLine(entry.EntryText);
			textWriter.WriteLine();
			textWriter.WriteLine();
			textWriter.Close();

		}

		public IEnumerable<Entry> GetLastEntries()
		{

			var entries = new List<Entry>();
			// read each entry in.
			var reader = File.OpenText(_fileName);
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
			return lastEntries;

		}
	}
}
