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
			Global.LoadSettings();			
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
			//save our settigns file BEFORE closing the app
			Global.SaveSettings();

			//make sure the link form closes when we close the program as well
			Global.gformLink.Close();		
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			//checking if the user has administration rights 
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);
				if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
					MessageBox.Show("This program may not function correctly without administrator rights!\nPlease change to an administrator account or make sure your current account has permission to create symbolic links.", "Warning", MessageBoxButtons.OK);
			}
		}
	}
}
