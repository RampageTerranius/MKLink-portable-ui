namespace mklink_portable_ui
{
	partial class frmSettings
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cboxShowCMD = new System.Windows.Forms.CheckBox();
			this.cBoxCheckIfTargetExists = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 58);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(93, 58);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cboxShowCMD
			// 
			this.cboxShowCMD.AutoSize = true;
			this.cboxShowCMD.Checked = true;
			this.cboxShowCMD.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cboxShowCMD.Location = new System.Drawing.Point(12, 12);
			this.cboxShowCMD.Name = "cboxShowCMD";
			this.cboxShowCMD.Size = new System.Drawing.Size(80, 17);
			this.cboxShowCMD.TabIndex = 10;
			this.cboxShowCMD.Text = "Show CMD";
			this.cboxShowCMD.UseVisualStyleBackColor = true;
			// 
			// cBoxCheckIfTargetExists
			// 
			this.cBoxCheckIfTargetExists.AutoSize = true;
			this.cBoxCheckIfTargetExists.Checked = true;
			this.cBoxCheckIfTargetExists.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cBoxCheckIfTargetExists.Location = new System.Drawing.Point(12, 35);
			this.cBoxCheckIfTargetExists.Name = "cBoxCheckIfTargetExists";
			this.cBoxCheckIfTargetExists.Size = new System.Drawing.Size(124, 17);
			this.cBoxCheckIfTargetExists.TabIndex = 11;
			this.cBoxCheckIfTargetExists.Text = "Check if target exists";
			this.cBoxCheckIfTargetExists.UseVisualStyleBackColor = true;
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(180, 93);
			this.ControlBox = false;
			this.Controls.Add(this.cBoxCheckIfTargetExists);
			this.Controls.Add(this.cboxShowCMD);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.VisibleChanged += new System.EventHandler(this.OnVisibleChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox cboxShowCMD;
		private System.Windows.Forms.CheckBox cBoxCheckIfTargetExists;
	}
}