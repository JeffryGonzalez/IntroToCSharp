namespace JournalVariation3ExtraCredit
{
	partial class EntryShower
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblDateOfEntry = new System.Windows.Forms.Label();
			this.lblTimeOfEntry = new System.Windows.Forms.Label();
			this.lblEntry = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDateOfEntry
			// 
			this.lblDateOfEntry.AutoSize = true;
			this.lblDateOfEntry.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.lblDateOfEntry.Location = new System.Drawing.Point(42, 31);
			this.lblDateOfEntry.Name = "lblDateOfEntry";
			this.lblDateOfEntry.Size = new System.Drawing.Size(93, 32);
			this.lblDateOfEntry.TabIndex = 0;
			this.lblDateOfEntry.Text = "label1";
			// 
			// lblTimeOfEntry
			// 
			this.lblTimeOfEntry.AutoSize = true;
			this.lblTimeOfEntry.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.lblTimeOfEntry.Location = new System.Drawing.Point(42, 72);
			this.lblTimeOfEntry.Name = "lblTimeOfEntry";
			this.lblTimeOfEntry.Size = new System.Drawing.Size(93, 32);
			this.lblTimeOfEntry.TabIndex = 1;
			this.lblTimeOfEntry.Text = "label2";
			// 
			// lblEntry
			// 
			this.lblEntry.AutoSize = true;
			this.lblEntry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblEntry.Location = new System.Drawing.Point(42, 115);
			this.lblEntry.Name = "lblEntry";
			this.lblEntry.Size = new System.Drawing.Size(93, 32);
			this.lblEntry.TabIndex = 2;
			this.lblEntry.Text = "label3";
			// 
			// EntryShower
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblEntry);
			this.Controls.Add(this.lblTimeOfEntry);
			this.Controls.Add(this.lblDateOfEntry);
			this.Name = "EntryShower";
			this.Size = new System.Drawing.Size(754, 205);
			this.Load += new System.EventHandler(this.EntryShower_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDateOfEntry;
		private System.Windows.Forms.Label lblTimeOfEntry;
		private System.Windows.Forms.Label lblEntry;
	}
}
