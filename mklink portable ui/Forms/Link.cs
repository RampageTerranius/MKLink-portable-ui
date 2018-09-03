using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mklink_portable_ui
{
	public partial class frmLink : Form
	{
		public frmLink()
		{
			InitializeComponent();			
		}

		//cancels closing the program and sends control back to the menu
		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Global.gformLink.Hide();
			Global.gformMain.Show();
		}

		//on Go button press
		private void btnGo_Click(object sender, EventArgs e)
		{
			if (tboxLinkLocation.Text != "" && tboxTarget.Text != "")
				Global.RunCMD(tboxLinkLocation.Text, tboxTarget.Text);
			else
				MessageBox.Show("Please enter a value into both Location AND Target", "Error", MessageBoxButtons.OK);
		}

		//used for when this form is opened
		private void OnVisibilityChange(object sender, EventArgs e)
		{
			//setting the text on lblMode depending upon the current mode we are in
			if (this.Visible)
				switch (Global.mode)
				{
					case "SymLink":
						lblMode.Text = "Symbolic Link";
						break;

					case "DirSymLink":
						lblMode.Text = "Directory Symbolic Link";
						break;

					case "HardLink":
						lblMode.Text = "Hard Link";
						break;

					case "DirJunk":
						lblMode.Text = "Directory Junction";
						break;
				}
		}

		private void btnBackToMenu_Click(object sender, EventArgs e)
		{
			//hand control over to OnClosing
			this.Close();
		}

		private void cboxShowCMD_CheckedChanged(object sender, EventArgs e)
		{
			if (cboxShowCMD.Checked)			
				Global.showCMD = true;	
			else
				Global.showCMD = false;
		}

		private void OnShown(object sender, EventArgs e)
		{
			cboxShowCMD.Checked = Global.showCMD;
		}
	}
}
