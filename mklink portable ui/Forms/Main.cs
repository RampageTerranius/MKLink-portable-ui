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
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			InitializeComponent();
		}

		private void btnSymLink_Click(object sender, EventArgs e)
		{
			Global.mode = "SymLink";

			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void btnDirSymLink_Click(object sender, EventArgs e)
		{
			Global.mode = "DirSymLink";

			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void btnHardLink_Click(object sender, EventArgs e)
		{
			Global.mode = "HardLink";

			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void btnDirJunk_Click(object sender, EventArgs e)
		{
			Global.mode = "DirJunk";

			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void OnClose(object sender, FormClosedEventArgs e)
		{
			Global.gformLink.Close();		
		}
	}
}
