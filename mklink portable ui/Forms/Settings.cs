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
	public partial class frmSettings : Form
	{
		public frmSettings()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (cboxShowCMD.CheckState == CheckState.Checked)
				Global.showCMD = true;
			else
				Global.showCMD = false;

			if (cBoxCheckIfTargetExists.CheckState == CheckState.Checked)
				Global.checkIfTargetExists = true;
			else
				Global.checkIfTargetExists = false;

			Global.SaveSettings();
			Global.gformSettings.Hide();

			switch (Global.sender)
			{
				case Sender.LINK:
					Global.gformLink.Show();
					break;

				case Sender.MENU:
					Global.gformMain.Show();
					break;
			}			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Global.gformSettings.Hide();
			switch (Global.sender)
			{
				case Sender.LINK:
					Global.gformLink.Show();
					break;

				case Sender.MENU:
					Global.gformMain.Show();
					break;
			}
		}

		private void OnVisibleChanged(object sender, EventArgs e)
		{
			//when we show the settins menu check the global settings and set them
			if (this.Visible)
			{
				if (Global.showCMD)
					cboxShowCMD.CheckState = CheckState.Checked;
				else
					cboxShowCMD.CheckState = CheckState.Unchecked;

				if (Global.checkIfTargetExists)
					cBoxCheckIfTargetExists.CheckState = CheckState.Checked;
				else
					cBoxCheckIfTargetExists.CheckState = CheckState.Unchecked;
			}
		}
	}
}