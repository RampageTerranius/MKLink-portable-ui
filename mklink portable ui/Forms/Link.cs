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

		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Global.gformLink.Hide();
			Global.gformMain.Show();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{

		}

		private void OnVisibilityChange(object sender, EventArgs e)
		{
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
	}
}
