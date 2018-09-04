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

		public static List<string> output;

		public static void CreateForms()
		{
			gformMain = new frmMenu();
			gformLink = new frmLink();
			showCMD = true;
			output = new List<string>();
		}

		//saving settings to ini as needed
		public static void SaveSettings()
		{
			
			if (File.Exists("settings.ini"))
			{
				//setting file exists, load it to memory, edit the memory then save it back to the file
				INI_Editor.INI file = new INI_Editor.INI("settings.ini");

				string str;
				if (showCMD)
					str = "true";
				else
					str = "false";

				file.EditValue("Settings", "ShowCMD", str);
				file.SaveAndClose();
			}
				else
			{
				//setting file does not yet exist, create it
				INI_Editor.INI file = new INI_Editor.INI();

				string str;
				if (showCMD)
					str = "true";
				else
					str = "false";

				file.AddTree("Settings");
				file.AddValue("Settings", "ShowCMD", str);
				file.SaveTo("settings.ini");
			} 
		}

		//loads settings file into memory
		public static void LoadSettings()
		{
			if (File.Exists("settings.ini"))
			{
				INI_Editor.INI file = new INI_Editor.INI("settings.ini");
				showCMD = file.GetValueAsBool("Settings", "ShowCMD");
			}
		}

		//used when not showing commands to get the output of the error
		private static void processDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
		{
			System.Diagnostics.Process process = sender as System.Diagnostics.Process;

			if (process != null)
				output.Add(e.Data);
		}

		private static void clearDataReceived()
		{
			output = new List<string>();
		}


		//used to run mklink
		public static void RunCMD(string location, string target)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.FileName = "cmd.exe";//the process we will be starting

			if (!showCMD)
			{
				startInfo.RedirectStandardOutput = true;
				startInfo.RedirectStandardError = true;
				startInfo.UseShellExecute = false;
				startInfo.CreateNoWindow = true;

				process.OutputDataReceived += processDataReceived;
				process.ErrorDataReceived += processDataReceived;
				clearDataReceived();
			}

			//preparing any extra parameters required for the process
			string type = "";						
			switch(Global.mode)
			{
				case "DirSymLink":
					type = "/d ";
					break;

				case "HardLink":
					type = "/h ";
					break;

				case "DirJunk":
					type = "/j ";
					break;
			}

			string arg;

			if (Global.showCMD)
				arg = "/k mklink ";
			else
				arg = "/c mklink ";

			arg += type +  "\"" +location + "\" \"" + target + "\"";
			startInfo.Arguments = arg;  
			process.StartInfo = startInfo;

			if (showCMD)
				process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;			
			else			
				process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			
				

			process.Start();

			if(!showCMD)
			{
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
			}

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
				{
					process.Close();
					string str = "Success!";
					foreach (string s in output)					
						if (s != "")
							str += "\n" + s;
					
					MessageBox.Show(str, "Info", MessageBoxButtons.OK);
				}
					
				else if (process.ExitCode == 1)
				{
					process.Close();
					string str = "Command Failed!";
					foreach (string s in output)
						if (s != "")
							str += "\n" + s;

					MessageBox.Show(str, "Info", MessageBoxButtons.OK);
				}
					
			}
		}
	}
}