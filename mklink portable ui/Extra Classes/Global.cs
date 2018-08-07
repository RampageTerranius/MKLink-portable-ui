using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mklink_portable_ui
{
	public static class Global
	{
		public static string mode = "";

		public static Form gformMain;
		public static Form gformLink;

		public static void CreateForms()
		{
			gformMain = new frmMenu();
			gformLink = new frmLink();
		}

		public static void Reset()
		{
			mode = "";			
		}

		public static void RunCMD(string argCMD)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C " + argCMD;
			process.StartInfo = startInfo;
			process.Start();

			bool wait = true;
			while (wait)			
				wait = process.WaitForExit(1000);

			if (process.ExitCode == 0)			
				MessageBox.Show("Success!", "Info", MessageBoxButtons.OK);			
			else if (process.ExitCode == 1)
				MessageBox.Show("Command Failed!", "Info", MessageBoxButtons.OK);
		}
	}
}
