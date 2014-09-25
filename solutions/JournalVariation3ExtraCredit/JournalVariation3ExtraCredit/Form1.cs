using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalDomain;

namespace JournalVariation3ExtraCredit
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private JournalWriter _journalWriter = new JournalWriter();

		private void Form1_Load(object sender, EventArgs e)
		{
			ShowOldEntries();
		}

		private void ShowOldEntries()
		{
			var top = 0;
			_oldEntries.Controls.Clear();
			foreach (var entry in _journalWriter.GetLastEntries())
			{
				var newEntry = new EntryShower(entry);
				newEntry.Top = top;
				_oldEntries.Controls.Add(newEntry);
				top += newEntry.Height;
			}
		}

		private void _addEntryButton_Click(object sender, EventArgs e)
		{
			_journalWriter.AddEntry(Entry.Create(_entryTextBox.Text));
			_entryTextBox.Clear();
			ShowOldEntries();

		}
	}
}
