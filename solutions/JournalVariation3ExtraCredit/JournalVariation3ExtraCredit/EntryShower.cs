using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalDomain;

namespace JournalVariation3ExtraCredit
{
	public partial class EntryShower : UserControl
	{
		public EntryShower(Entry entry)
		{
			InitializeComponent();
			lblDateOfEntry.Text = entry.EntryDate.ToLongDateString();
			lblTimeOfEntry.Text = entry.EntryText;
			lblEntry.Text = entry.EntryText;
		}

		private void EntryShower_Load(object sender, EventArgs e)
		{

		}
	}
}
