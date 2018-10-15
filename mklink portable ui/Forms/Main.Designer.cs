namespace mklink_portable_ui
{
	partial class frmMenu
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
			this.btnSymLink = new System.Windows.Forms.Button();
			this.btnDirSymLink = new System.Windows.Forms.Button();
			this.btnHardLink = new System.Windows.Forms.Button();
			this.btnDirJunk = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSymLink
			// 
			this.btnSymLink.Location = new System.Drawing.Point(12, 12);
			this.btnSymLink.Name = "btnSymLink";
			this.btnSymLink.Size = new System.Drawing.Size(92, 35);
			this.btnSymLink.TabIndex = 0;
			this.btnSymLink.Text = "File Symbolic link";
			this.btnSymLink.UseVisualStyleBackColor = true;
			this.btnSymLink.Click += new System.EventHandler(this.btnSymLink_Click);
			// 
			// btnDirSymLink
			// 
			this.btnDirSymLink.Location = new System.Drawing.Point(12, 53);
			this.btnDirSymLink.Name = "btnDirSymLink";
			this.btnDirSymLink.Size = new System.Drawing.Size(92, 35);
			this.btnDirSymLink.TabIndex = 1;
			this.btnDirSymLink.Text = "Directory Symbolic link";
			this.btnDirSymLink.UseVisualStyleBackColor = true;
			this.btnDirSymLink.Click += new System.EventHandler(this.btnDirSymLink_Click);
			// 
			// btnHardLink
			// 
			this.btnHardLink.Location = new System.Drawing.Point(12, 94);
			this.btnHardLink.Name = "btnHardLink";
			this.btnHardLink.Size = new System.Drawing.Size(92, 35);
			this.btnHardLink.TabIndex = 2;
			this.btnHardLink.Text = "Hard link";
			this.btnHardLink.UseVisualStyleBackColor = true;
			this.btnHardLink.Click += new System.EventHandler(this.btnHardLink_Click);
			// 
			// btnDirJunk
			// 
			this.btnDirJunk.Location = new System.Drawing.Point(12, 135);
			this.btnDirJunk.Name = "btnDirJunk";
			this.btnDirJunk.Size = new System.Drawing.Size(92, 35);
			this.btnDirJunk.TabIndex = 3;
			this.btnDirJunk.Text = "Directory Junction";
			this.btnDirJunk.UseVisualStyleBackColor = true;
			this.btnDirJunk.Click += new System.EventHandler(this.btnDirJunk_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.Location = new System.Drawing.Point(12, 176);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(92, 35);
			this.btnSettings.TabIndex = 4;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(116, 223);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.btnDirJunk);
			this.Controls.Add(this.btnHardLink);
			this.Controls.Add(this.btnDirSymLink);
			this.Controls.Add(this.btnSymLink);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmMenu";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
			this.Load += new System.EventHandler(this.frmMenu_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSymLink;
		private System.Windows.Forms.Button btnDirSymLink;
		private System.Windows.Forms.Button btnHardLink;
		private System.Windows.Forms.Button btnDirJunk;
		private System.Windows.Forms.Button btnSettings;
	}
}

