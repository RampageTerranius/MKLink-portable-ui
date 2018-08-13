using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mklink_portable_ui
{
	//used to store global variables and functions used between all forms
	public static class Global
	{
		public static string mode = "";

		public static Form gformMain;
		public static Form gformLink;
		public static bool showCMD;

		public static void CreateForms()
		{
			gformMain = new frmMenu();
			gformLink = new frmLink();
			showCMD = true;
		}

		//used to run mklink
		public static void RunCMD(string location, string target)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.FileName = "cmd.exe";//the process we will be starting

			//preparing any extra parameters required for the process
			string type = "";						
			switch(Global.mode)
			{
				case "DirSymLink":
					type = " /D ";
					break;

				case "HardLink":
					type = " /H ";
					break;

				case "DirJunk":
					type = " /J ";
					break;
			}

			string arg;

			if (Global.showCMD)
				arg = "/k mklink ";
			else
				arg = "/c mklink ";

			arg += type + location + " " + target;
			startInfo.Arguments = arg;  
			process.StartInfo = startInfo;

			if (showCMD)
				process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
			
			else			
				process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			
				

			process.Start();

			//wait until external process has exited
			bool wait = true;
			while (wait)
			{
				System.Threading.Thread.Sleep(1000);
				if (process.HasExited)
					wait = false;
			}

			//show if process succeeded
			if (!Global.showCMD)
			{
				if (process.ExitCode == 0)
					MessageBox.Show("Success!", "Info", MessageBoxButtons.OK);
				else if (process.ExitCode == 1)
					MessageBox.Show("Command Failed!", "Info", MessageBoxButtons.OK);
			}
		}
	}
}