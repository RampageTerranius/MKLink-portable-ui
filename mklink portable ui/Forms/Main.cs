using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

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
			//set what mode we are using in the link form
			Global.mode = "SymLink";

			//show link form and hide menu
			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void btnDirSymLink_Click(object sender, EventArgs e)
		{
			//set what mode we are using in the link form
			Global.mode = "DirSymLink";

			//show link form and hide menu
			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void btnHardLink_Click(object sender, EventArgs e)
		{
			//set what mode we are using in the link form
			Global.mode = "HardLink";

			//show link form and hide menu
			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		//on Directory Junktion button click
		private void btnDirJunk_Click(object sender, EventArgs e)
		{
			//set what mode we are using in the link form
			Global.mode = "DirJunk";

			//show link form and hide menu
			Global.gformLink.Show();
			Global.gformMain.Hide();
		}

		private void OnClose(object sender, FormClosedEventArgs e)
		{
			//make sure the link form closes when we clsoe the program as well
			Global.gformLink.Close();		
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			//checking if the user has administration rights 
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);
				if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
					MessageBox.Show("Warning!\nThis program may not function correctly without administrator rights!", "Warning", MessageBoxButtons.OK);
			}
		}
	}
}
