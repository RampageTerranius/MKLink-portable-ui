namespace mklink_portable_ui
{
	partial class frmLink
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
			this.lblTarget = new System.Windows.Forms.Label();
			this.lblLinkLocation = new System.Windows.Forms.Label();
			this.btnBrowse1 = new System.Windows.Forms.Button();
			this.btnBrowse2 = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.tboxTarget = new System.Windows.Forms.TextBox();
			this.tboxLinkLocation = new System.Windows.Forms.TextBox();
			this.lblMode = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTarget
			// 
			this.lblTarget.AutoSize = true;
			this.lblTarget.Location = new System.Drawing.Point(12, 9);
			this.lblTarget.Name = "lblTarget";
			this.lblTarget.Size = new System.Drawing.Size(38, 13);
			this.lblTarget.TabIndex = 0;
			this.lblTarget.Text = "Target";
			// 
			// lblLinkLocation
			// 
			this.lblLinkLocation.AutoSize = true;
			this.lblLinkLocation.Location = new System.Drawing.Point(12, 51);
			this.lblLinkLocation.Name = "lblLinkLocation";
			this.lblLinkLocation.Size = new System.Drawing.Size(71, 13);
			this.lblLinkLocation.TabIndex = 1;
			this.lblLinkLocation.Text = "Link Location";
			// 
			// btnBrowse1
			// 
			this.btnBrowse1.Location = new System.Drawing.Point(15, 25);
			this.btnBrowse1.Name = "btnBrowse1";
			this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse1.TabIndex = 2;
			this.btnBrowse1.Text = "Browse";
			this.btnBrowse1.UseVisualStyleBackColor = true;
			// 
			// btnBrowse2
			// 
			this.btnBrowse2.Location = new System.Drawing.Point(15, 67);
			this.btnBrowse2.Name = "btnBrowse2";
			this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse2.TabIndex = 3;
			this.btnBrowse2.Text = "Browse";
			this.btnBrowse2.UseVisualStyleBackColor = true;
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(15, 96);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// tboxTarget
			// 
			this.tboxTarget.Location = new System.Drawing.Point(96, 27);
			this.tboxTarget.Name = "tboxTarget";
			this.tboxTarget.Size = new System.Drawing.Size(692, 20);
			this.tboxTarget.TabIndex = 5;
			// 
			// tboxLinkLocation
			// 
			this.tboxLinkLocation.Location = new System.Drawing.Point(96, 69);
			this.tboxLinkLocation.Name = "tboxLinkLocation";
			this.tboxLinkLocation.Size = new System.Drawing.Size(692, 20);
			this.tboxLinkLocation.TabIndex = 6;
			// 
			// lblMode
			// 
			this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMode.Location = new System.Drawing.Point(96, 9);
			this.lblMode.Name = "lblMode";
			this.lblMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMode.Size = new System.Drawing.Size(692, 15);
			this.lblMode.TabIndex = 7;
			this.lblMode.Text = "ModeText";
			this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmLink
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 133);
			this.Controls.Add(this.lblMode);
			this.Controls.Add(this.tboxLinkLocation);
			this.Controls.Add(this.tboxTarget);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnBrowse2);
			this.Controls.Add(this.btnBrowse1);
			this.Controls.Add(this.lblLinkLocation);
			this.Controls.Add(this.lblTarget);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmLink";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
			this.VisibleChanged += new System.EventHandler(this.OnVisibilityChange);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTarget;
		private System.Windows.Forms.Label lblLinkLocation;
		private System.Windows.Forms.Button btnBrowse1;
		private System.Windows.Forms.Button btnBrowse2;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox tboxTarget;
		private System.Windows.Forms.TextBox tboxLinkLocation;
		private System.Windows.Forms.Label lblMode;
	}


}