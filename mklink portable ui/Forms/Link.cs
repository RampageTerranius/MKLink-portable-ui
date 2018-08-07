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

		private void OnShown(object sender, EventArgs e)
		{
			lblMode.Text = Global.mode;
		}
	}
}
