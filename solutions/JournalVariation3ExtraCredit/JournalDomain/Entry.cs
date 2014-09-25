using System;

namespace JournalDomain
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

		public static Entry Create(string entryText)
		{
			entryText = entryText.Length > 140 ? entryText.Substring(0, 140) : entryText;
			return new Entry(DateTime.Now.ToLongDateString(), DateTime.Now.ToShortTimeString(), entryText);
		}
	}
}
