namespace JournalVariation3ExtraCredit
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._oldEntries = new System.Windows.Forms.Panel();
			this._entryTextBox = new System.Windows.Forms.TextBox();
			this._addEntryButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _oldEntries
			// 
			this._oldEntries.AutoScroll = true;
			this._oldEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._oldEntries.Location = new System.Drawing.Point(13, 13);
			this._oldEntries.Name = "_oldEntries";
			this._oldEntries.Size = new System.Drawing.Size(673, 1140);
			this._oldEntries.TabIndex = 0;
			// 
			// _entryTextBox
			// 
			this._entryTextBox.Location = new System.Drawing.Point(737, 56);
			this._entryTextBox.MaxLength = 140;
			this._entryTextBox.Multiline = true;
			this._entryTextBox.Name = "_entryTextBox";
			this._entryTextBox.Size = new System.Drawing.Size(667, 217);
			this._entryTextBox.TabIndex = 1;
			// 
			// _addEntryButton
			// 
			this._addEntryButton.Location = new System.Drawing.Point(950, 332);
			this._addEntryButton.Name = "_addEntryButton";
			this._addEntryButton.Size = new System.Drawing.Size(235, 103);
			this._addEntryButton.TabIndex = 2;
			this._addEntryButton.Text = "Add Entry";
			this._addEntryButton.UseVisualStyleBackColor = true;
			this._addEntryButton.Click += new System.EventHandler(this._addEntryButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1459, 1178);
			this.Controls.Add(this._addEntryButton);
			this.Controls.Add(this._entryTextBox);
			this.Controls.Add(this._oldEntries);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel _oldEntries;
		private System.Windows.Forms.TextBox _entryTextBox;
		private System.Windows.Forms.Button _addEntryButton;
	}
}

