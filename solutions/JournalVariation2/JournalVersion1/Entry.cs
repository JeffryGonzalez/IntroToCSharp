using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalVersion1
{
	public class Entry
	{
		public Entry(string entryDate, string entryTime, string entryText)
		{
			EntryDate = DateTime.Parse(entryDate + " " + entryTime);
			EntryTime = entryTime;
			EntryText = entryText;
		}

		public DateTime EntryDate { get; private set; }
		public string EntryTime { get; private set; }
		public string EntryText { get; private set; }
	}
}
